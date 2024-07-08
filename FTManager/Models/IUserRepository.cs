using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Models
{
    internal interface IUserRepository
    {
        User GetUser(string username);
    }
}
