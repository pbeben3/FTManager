using FTManager.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Repositories
{
    internal class TrainingSessionRepository :BaseRepository, ITrainingSessionRepository
    {
        public TrainingSessionRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<TrainingSession> GetAllTrainings()
        {
            List<TrainingSession> trainingSessions = new List<TrainingSession>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM TrainingSessions";
                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TrainingSession trainingSession = new TrainingSession
                        {
                            SessionId = Convert.ToInt32(reader["SessionId"]),
                            ClubId = Convert.ToInt32(reader["ClubId"]),
                            Date = Convert.ToDateTime(reader["Date"]),
                            HourOfBeggining = reader["HourOfBeggining"].ToString(),
                            HourOfEnded = reader["HourOfEnd"].ToString()
                        };
                        trainingSessions.Add(trainingSession);
                    }
                }
            }

            return trainingSessions;
        }

        public TrainingSession GetTrainingSessionById(int trainingSessionId)
        {
            TrainingSession trainingSession = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM TrainingSessions WHERE SessionId = @SessionId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SessionId", trainingSessionId);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        trainingSession = new TrainingSession
                        {
                            SessionId = Convert.ToInt32(reader["SessionId"]),
                            ClubId = Convert.ToInt32(reader["ClubId"]),
                            Date = Convert.ToDateTime(reader["Date"]),
                            HourOfBeggining = reader["HourOfBeggining"].ToString(),
                            HourOfEnded = reader["HourOfEnded"].ToString()
                        };
                    }
                }
            }

            return trainingSession;
        }

        public void AddTrainingSession(TrainingSession trainingSession)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"INSERT INTO TrainingSessions (ClubId, Date, HourOfBeggining, HourOfEnd) 
                             VALUES (@ClubId, @Date, @HourOfBeggining, @HourOfEnd)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClubId", trainingSession.ClubId);
                command.Parameters.AddWithValue("@Date", trainingSession.Date);
                command.Parameters.AddWithValue("@HourOfBeggining", trainingSession.HourOfBeggining);
                command.Parameters.AddWithValue("@HourOfEnd", trainingSession.HourOfEnded);
                command.ExecuteNonQuery();
            }
        }

        public void DeleteTrainingSession(int trainingSessionId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM TrainingSessions WHERE SessionId = @SessionId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SessionId", trainingSessionId);
                command.ExecuteNonQuery();
            }
        }

        public void EditTrainingSession(TrainingSession trainingSession)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"UPDATE TrainingSessions 
                                 SET  
                                     Date = @Date, 
                                     HourOfBeggining = @HourOfBeggining, 
                                     HourOfEnd = @HourOfEnd 
                               WHERE SessionId = @SessionId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Date", trainingSession.Date);
                command.Parameters.AddWithValue("@HourOfBeggining", trainingSession.HourOfBeggining);
                command.Parameters.AddWithValue("@HourOfEnd", trainingSession.HourOfEnded);
                command.Parameters.AddWithValue("@SessionId", trainingSession.SessionId);
                command.ExecuteNonQuery();
            }
        }
    }
}
