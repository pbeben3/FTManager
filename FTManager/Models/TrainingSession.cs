using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Models
{
    internal class TrainingSession
    {
        public int ClubId { get; set; }
        public int SessionId { get; set; }
        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Hour of Beginning is required")]
        [RegularExpression(@"^(?:[01]?[0-9]|2[0-3]):[0-5][0-9]$", ErrorMessage = "Hour of Beginning must be in HH:mm format")]
        public string HourOfBeggining { get; set; }
        [Required(ErrorMessage = "Hour of Ended is required")]
        [RegularExpression(@"^(?:[01]?[0-9]|2[0-3]):[0-5][0-9]$", ErrorMessage = "Hour of Ended must be in HH:mm format")]
        public string HourOfEnded { get; set; }
    }
}
