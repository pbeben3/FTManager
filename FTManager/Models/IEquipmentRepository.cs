using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Models
{
    internal interface IEquipmentRepository
    {
        void AddEquipment(Equipment equipment);
        List<Equipment> GetAllEquipment();
        void DeleteEquipment(int equipmentId);
        void EditEquipment(Equipment equipment);
    }
}
