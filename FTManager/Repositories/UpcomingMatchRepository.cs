using FTManager.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Repositories
{
    internal class UpcomingMatchRepository : BaseRepository, IUpcomingMatchRepository
    {
        public UpcomingMatchRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddUpcomingMatch(UpcomingMatch match)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"INSERT INTO UpcomingMatches (ClubId, Date, Place, Opponent) 
                             VALUES (@ClubId, @Date, @Place, @Opponent)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClubId", match.ClubId);
                command.Parameters.AddWithValue("@Date", match.Date);
                command.Parameters.AddWithValue("@Place", match.Place);
                command.Parameters.AddWithValue("@Opponent", match.Opponent);
                command.ExecuteNonQuery();
            }
        }

        public List<UpcomingMatch> GetAllUpcomingMatches()
        {
            List<UpcomingMatch> matchList = new List<UpcomingMatch>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM UpcomingMatches";
                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        UpcomingMatch match = new UpcomingMatch
                        {
                            ClubId = Convert.ToInt32(reader["ClubId"]),
                            Id = Convert.ToInt32(reader["Id"]),
                            Date = Convert.ToDateTime(reader["Date"]),
                            Place = reader["Place"].ToString(),
                            Opponent = reader["Opponent"].ToString(),

                        };
                        matchList.Add(match);
                    }
                }
            }

            return matchList;
        }
        public void DeleteUpcomingMatch(int matchId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM UpcomingMatches WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", matchId);
                command.ExecuteNonQuery();
            }
        }
        public void EditUpcomingMatch(UpcomingMatch match)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"UPDATE UpcomingMatches 
                         SET  
                             Date = @Date, 
                             Place = @Place, 
                             Opponent = @Opponent 
                       WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Date", match.Date);
                command.Parameters.AddWithValue("@Place", match.Place);
                command.Parameters.AddWithValue("@Opponent", match.Opponent);
                command.Parameters.AddWithValue("@Id", match.Id);
                command.ExecuteNonQuery();
            }
        }


    }
}
