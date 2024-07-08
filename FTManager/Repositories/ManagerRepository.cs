using FTManager.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Repositories
{
    internal class ManagerRepository : BaseRepository, IManagerRepository
    {
        public ManagerRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Manager> GetAllManagers()
        {
            List<Manager> managers = new List<Manager>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Managers";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Manager manager = new Manager()
                        {
                            UserId = Convert.ToInt32(reader["UserId"]),
                            Name = reader["Name"].ToString(),
                            Surname = reader["Surname"].ToString(),
                            Nationality = reader["Nationality"].ToString(),
                            Age = Convert.ToInt32(reader["Age"]),
                            HireDate = DateTime.Parse(reader["HireDate"].ToString())
                        };

                        managers.Add(manager);
                    }
                }
            }
            return managers;
        }

        public Manager GetManagerById(int managerId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT m.UserId, m.Name, m.Surname, m.Nationality, m.Age, m.HireDate, 
                   u.ClubId, u.Username, u.Password, u.Role
            FROM Managers m
            INNER JOIN Users u ON m.UserId = u.UserId
            WHERE m.UserId = @UserId";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", managerId);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        Manager manager = new Manager()
                        {
                            UserId = Convert.ToInt32(reader["UserId"]),
                            Name = reader["Name"].ToString(),
                            Surname = reader["Surname"].ToString(),
                            Nationality = reader["Nationality"].ToString(),
                            Age = Convert.ToInt32(reader["Age"]),
                            HireDate = DateTime.Parse(reader["HireDate"].ToString()),
                            ClubId = Convert.ToInt32(reader["ClubId"]),
                            Username = reader["Username"].ToString(),
                            Password = reader["Password"].ToString(),
                            Role = reader["Role"].ToString()
                        };

                        return manager;
                    }
                }
            }

            return null;
        }

        public void AddManager(Manager manager)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlTransaction transaction = connection.BeginTransaction())
                {
                    try
                    {

                        string userQuery = "INSERT INTO Users (ClubId, Username, Password, Role) OUTPUT INSERTED.UserId VALUES (@ClubId, @Username, @Password, @Role)";
                        SqlCommand userCommand = new SqlCommand(userQuery, connection, transaction);
                        userCommand.Parameters.AddWithValue("@ClubId", manager.ClubId);
                        userCommand.Parameters.AddWithValue("@Username", manager.Username);
                        userCommand.Parameters.AddWithValue("@Password", manager.Password);
                        userCommand.Parameters.AddWithValue("@Role", "Manager");

                        int userId = (int)userCommand.ExecuteScalar();


                        string managerQuery = "INSERT INTO Managers (UserId, Name, Surname, Nationality, Age, HireDate) VALUES (@UserId, @Name, @Surname, @Nationality, @Age, @HireDate)";
                        SqlCommand playerCommand = new SqlCommand(managerQuery, connection, transaction);
                        playerCommand.Parameters.AddWithValue("@UserId", userId);
                        playerCommand.Parameters.AddWithValue("@Name", manager.Name);
                        playerCommand.Parameters.AddWithValue("@Surname", manager.Surname);
                        playerCommand.Parameters.AddWithValue("@Age", manager.Age);
                        playerCommand.Parameters.AddWithValue("@Nationality", manager.Nationality);
                        playerCommand.Parameters.AddWithValue("@HireDate", manager.HireDate);

                        playerCommand.ExecuteNonQuery();

                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw new Exception("An error occurred while adding manager", ex);
                    }
                }
            }
        }

        public void DeleteManager(int managerId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Users WHERE UserId = @UserId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", managerId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void EditManager(Manager manager)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"UPDATE Managers 
                                 SET  
                                     Name = @Name, 
                                     Surname = @Surname, 
                                     Nationality = @Nationality, 
                                     Age = @Age, 
                                     HireDate = @HireDate 
                               WHERE UserId = @UserId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", manager.Name);
                command.Parameters.AddWithValue("@Surname", manager.Surname);
                command.Parameters.AddWithValue("@Nationality", manager.Nationality);
                command.Parameters.AddWithValue("@Age", manager.Age);
                command.Parameters.AddWithValue("@HireDate", manager.HireDate);
                command.Parameters.AddWithValue("@UserId", manager.UserId);
                command.ExecuteNonQuery();
            }
        }
    }
}

