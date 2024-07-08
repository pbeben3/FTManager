using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Models
{
    internal class Equipment
    {
        public int ClubId { get; set; }
        public int EquipmentId { get; set; }
        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 100 characters")]
        public string Name { get; set; }
        [StringLength(25, ErrorMessage = "Condition must be maximum 25 characters")]
        public string Condition { get; set; }
        [RegularExpression(@"^\d+$", ErrorMessage = "Quantity must be a positive number")]
        public int Quantity { get; set; }
        [Required(ErrorMessage = "Date of Purchase is required")]
        [DataType(DataType.Date, ErrorMessage = "Invalid Date format")]
        public DateTime DateOfPurchase { get; set; }
    }
}
