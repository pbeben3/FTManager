using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Models
{
    internal interface IManagerRepository
    {
        List<Manager> GetAllManagers();
        Manager GetManagerById(int managerId);
        void AddManager(Manager manager);
        void DeleteManager(int maangerId);
        void EditManager(Manager maanger);
    }
}
