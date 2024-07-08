using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Models
{
    internal class UpcomingMatch
    {
        public int ClubId { get; set; }
        public int Id { get; set; }
        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Place is required")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "Place must be between 5 and 25 characters")]
        public string Place { get; set; }
        [Required(ErrorMessage = "Opponent is required")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "Opponent must be between 5 and 25 characters")]
        public string Opponent { get; set; }
    }
}
