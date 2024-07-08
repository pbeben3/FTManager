using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Views
{
    internal interface ITrainingSessionView
    {
        int CLubId { get; set; }
        int SessionId { get; set; }
        string Date {  get; set; }
        string HourOfBeggining { get; set; }
        string HourOfEnded { get; set;}
        bool IsEdit { get; set; }
        bool IsSuccess { get; set; }
        event EventHandler LoadTrainingsEvent;
        event EventHandler AddTrainingEvent;
        event EventHandler EditTrainingEvent;
        event EventHandler SaveTrainingEvent;
        event EventHandler DeleteTrainingEvent;
        event EventHandler CancelEvent;
        public void SetTrainingsListBindingSource(BindingSource trainingsList);
        void Show();
        void ConfigureDataGridView();
        void ShowMessage(string message);

        void HideAddTrainingControls();
    }
}
