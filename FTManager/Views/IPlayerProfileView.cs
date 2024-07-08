using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Views
{
    internal interface IPlayerProfileView
    {
        string Name { get; set; }
        string Surname { get; set; }
        string Age { get; set; }
        string Nationality { get; set; }
        string Position { get; set; }
        void Show();
        event EventHandler LoadPlayerProfileEvent;
    }
}
