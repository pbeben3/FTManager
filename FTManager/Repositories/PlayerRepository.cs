using FTManager.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Repositories
{
    internal class PlayerRepository : BaseRepository , IPlayerRepository
    {

        public PlayerRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Player> GetAllPlayers()
        {
            List<Player> players = new List<Player>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Players";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Player player = new Player
                        {
                            //PlayerID = Convert.ToInt32(reader["PlayerID"]),
                            UserId = Convert.ToInt32(reader["UserId"]),
                            Name = reader["Name"].ToString(),
                            Surname = reader["Surname"].ToString(),
                            Age = Convert.ToInt32(reader["Age"]),
                            Nationality = reader["Nationality"].ToString(),
                            Position = reader["Position"].ToString()
                        };

                        players.Add(player);
                    }
                }
            }
            return players;
        }

        public Player GetPlayerById(int userId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT p.UserId, p.Name, p.Surname, p.Age, p.Nationality, p.Position,
                   u.ClubId, u.Username, u.Password, u.Role
            FROM Players p
            INNER JOIN Users u ON p.UserId = u.UserId
            WHERE p.UserId = @UserId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Player player = new Player
                        {
                            UserId = Convert.ToInt32(reader["UserId"]),
                            Name = reader["Name"].ToString(),
                            Surname = reader["Surname"].ToString(),
                            Age = Convert.ToInt32(reader["Age"]),
                            Nationality = reader["Nationality"].ToString(),
                            Position = reader["Position"].ToString(),
                            ClubId = Convert.ToInt32(reader["ClubId"]),
                            Username = reader["Username"].ToString(),
                            Password = reader["Password"].ToString(),
                            Role = reader["Role"].ToString()
                        };

                        return player;
                    }
                }
            }

            return null;
        }

        public void AddPlayer(Player player)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {
                        string userQuery = @"
                    INSERT INTO Users (ClubId, Username, Password, Role) 
                    OUTPUT INSERTED.UserId 
                    VALUES (@ClubId, @Username, @Password, @Role)";

                        SqlCommand userCommand = new SqlCommand(userQuery, connection, transaction);
                        userCommand.Parameters.AddWithValue("@ClubId", player.ClubId);
                        userCommand.Parameters.AddWithValue("@Username", player.Username);
                        userCommand.Parameters.AddWithValue("@Password", player.Password);
                        userCommand.Parameters.AddWithValue("@Role", "Player");

                        int userId = (int)userCommand.ExecuteScalar();

                        string playerQuery = @"
                    INSERT INTO Players (UserId, Name, Surname, Age, Nationality, Position) 
                    VALUES (@UserId, @Name, @Surname, @Age, @Nationality, @Position)";

                        SqlCommand playerCommand = new SqlCommand(playerQuery, connection, transaction);
                        playerCommand.Parameters.AddWithValue("@UserId", userId);
                        playerCommand.Parameters.AddWithValue("@Name", player.Name);
                        playerCommand.Parameters.AddWithValue("@Surname", player.Surname);
                        playerCommand.Parameters.AddWithValue("@Age", player.Age);
                        playerCommand.Parameters.AddWithValue("@Nationality", player.Nationality);
                        playerCommand.Parameters.AddWithValue("@Position", player.Position);


                        playerCommand.ExecuteNonQuery();


                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {

                        transaction.Rollback();
                        throw new Exception("An error occurred while adding player", ex);
                    }
                }
            }
        }

        public void DeletePlayer(int playerId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Users WHERE UserId = @UserId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", playerId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void EditPlayer(Player player)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"UPDATE Players 
                         SET  
                             Name = @Name, 
                             Surname = @Surname, 
                             Age = @Age, 
                             Nationality = @Nationality, 
                             Position = @Position 
                       WHERE UserId = @UserId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", player.Name);
                command.Parameters.AddWithValue("@Surname", player.Surname);
                command.Parameters.AddWithValue("@Age", player.Age);
                command.Parameters.AddWithValue("@Nationality", player.Nationality);
                command.Parameters.AddWithValue("@Position", player.Position);
                command.Parameters.AddWithValue("@UserId", player.UserId);
                command.ExecuteNonQuery();
            }
        }

    }
}
