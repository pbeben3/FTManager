using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Models
{
    internal class MatchPlayed
    {
        public int ClubId { get; set; }
        public int Id { get; set; }
        [Required(ErrorMessage = "Match Date is required")]
        [DataType(DataType.Date)]
        public DateTime MatchDate { get; set; }
        [Required(ErrorMessage = "Place is required")]
        [StringLength(25, MinimumLength = 5, ErrorMessage = "Place must be between 5 and 25 characters")]
        public string Place { get; set; }
        [Required(ErrorMessage = "Opponent is required")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "Opponent must be between 1 and 25 characters")]
        public string Opponent { get; set; }
        [Required(ErrorMessage = "Score is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Score must be a non-negative number")]
        public int Score { get; set; }
        [Required(ErrorMessage = "Opponent Score is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Opponent Score must be a non-negative number")]
        public int OpponentScore { get; set; }


    }
}
