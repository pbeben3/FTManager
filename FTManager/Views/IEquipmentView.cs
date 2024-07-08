using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Views
{
    internal interface IEquipmentView
    {
        int ClubId { get; set; }
        int EquipmentId { get; set; }
        string Name { get; set; }
        string Condition { get; set; }
        string Quantity { get; set; }
        string DateOfPurchase { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccess { get; set; }
        event EventHandler LoadEquipmentEvent;
        event EventHandler SaveEquipmentEvent;
        event EventHandler AddEquipmentEvent;
        event EventHandler EditEquipmentEvent;
        event EventHandler DeleteEquipmentEvent;
        event EventHandler CancelEvent;
        public void SetEquipmentListBindingSource(BindingSource equimpentList);
        public void ConfigureDataGridView();
        void ShowMessage(string message);
        void Show();

    }
}
