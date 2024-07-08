using FTManager.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Repositories
{
    internal class EquipmentRepository : BaseRepository, IEquipmentRepository
    {
        public EquipmentRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void AddEquipment(Equipment equipment)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"INSERT INTO Equipment (ClubId, Name, Condition, Quantity, DateOfPurchase) 
                             VALUES (@ClubId, @Name, @Condition, @Quantity, @DateOfPurchase)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClubId", equipment.ClubId);
                command.Parameters.AddWithValue("@Name", equipment.Name);
                command.Parameters.AddWithValue("@Condition", equipment.Condition);
                command.Parameters.AddWithValue("@Quantity", equipment.Quantity);
                command.Parameters.AddWithValue("@DateOfPurchase", equipment.DateOfPurchase);
                command.ExecuteNonQuery();
            }
        }

        public List<Equipment> GetAllEquipment()
        {
            List<Equipment> equipmentList = new List<Equipment>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Equipment";
                SqlCommand command = new SqlCommand(query, connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Equipment equipment = new Equipment
                        {
                            EquipmentId = Convert.ToInt32(reader["EquipmentId"]),
                            Name = reader["Name"].ToString(),
                            Condition = reader["Condition"].ToString(),
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            DateOfPurchase = Convert.ToDateTime(reader["DateOfPurchase"])
                        };
                        equipmentList.Add(equipment);
                    }
                }
            }

            return equipmentList;
        }

        public void DeleteEquipment(int equipmentId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Equipment WHERE EquipmentId = @EquipmentId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@EquipmentId", equipmentId);
                command.ExecuteNonQuery();
            }
        }
        public void EditEquipment(Equipment equipment)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"UPDATE Equipment 
                         SET  
                             Name = @Name, 
                             Condition = @Condition, 
                             Quantity = @Quantity, 
                             DateOfPurchase = @DateOfPurchase 
                         WHERE EquipmentId = @EquipmentId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", equipment.Name);
                command.Parameters.AddWithValue("@Condition", equipment.Condition);
                command.Parameters.AddWithValue("@Quantity", equipment.Quantity);
                command.Parameters.AddWithValue("@DateOfPurchase", equipment.DateOfPurchase);
                command.Parameters.AddWithValue("@EquipmentId", equipment.EquipmentId);

                command.ExecuteNonQuery();
            }
        }
    }
}
