using FTManager.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Repositories
{
    internal class MatchPlayedRepository : BaseRepository, IMatchPlayedRepository
    {
        public MatchPlayedRepository(string connectionString) 
        {
            this.connectionString = connectionString;
        }
        public void AddMatchPlayed(MatchPlayed match)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"INSERT INTO MatchesPlayed (ClubId, MatchDate, Place, Opponent, Score, OpponentScore) 
                             VALUES (@ClubId, @MatchDate, @Place, @Opponent, @Score, @OpponentScore)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClubId", match.ClubId);
                command.Parameters.AddWithValue("@MatchDate", match.MatchDate);
                command.Parameters.AddWithValue("@Place", match.Place);
                command.Parameters.AddWithValue("@Opponent", match.Opponent);
                command.Parameters.AddWithValue("@Score", match.Score);
                command.Parameters.AddWithValue("@OpponentScore", match.OpponentScore);
                command.ExecuteNonQuery();
            }
        }

        public List<MatchPlayed> GetAllMatchesPlayed()
        {
            List<MatchPlayed> matchesPlayed = new List<MatchPlayed>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM MatchesPlayed";
                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MatchPlayed match = new MatchPlayed
                        {
                            Id = Convert.ToInt32(reader["MatchId"]),
                            MatchDate = Convert.ToDateTime(reader["MatchDate"]),
                            Place = reader["Place"].ToString(),
                            Opponent = reader["Opponent"].ToString(),
                            Score = Convert.ToInt32(reader["Score"]),
                            OpponentScore = Convert.ToInt32(reader["OpponentScore"])
                        };
                        matchesPlayed.Add(match);
                    }
                }
            }

            return matchesPlayed;
        }
        public void DeleteMatchPlayed(int matchId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM MatchesPlayed WHERE MatchId = @MatchId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MatchId", matchId);
                command.ExecuteNonQuery();
            }
        }
        public void EditMatchPlayed(MatchPlayed match)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"UPDATE MatchesPlayed 
                         SET  
                             MatchDate = @MatchDate, 
                             Place = @Place, 
                             Opponent = @Opponent,
                             Score = @Score,
                             OpponentScore = @OpponentScore 
                       WHERE MatchId = @MatchId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@MatchDate", match.MatchDate);
                command.Parameters.AddWithValue("@Place", match.Place);
                command.Parameters.AddWithValue("@Opponent", match.Opponent);
                command.Parameters.AddWithValue("@Score", match.Score);
                command.Parameters.AddWithValue("@OpponentScore", match.OpponentScore);
                command.Parameters.AddWithValue("@MatchId", match.Id);
                command.ExecuteNonQuery();
            }
        }
    }
}
