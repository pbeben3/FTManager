using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FTManager.Models
{
    internal class Manager : User
    {
        [Required(ErrorMessage = "Name is required")]
        [RegularExpression(@"^[a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ]+$", ErrorMessage = "Name must contain only letters")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 25 characters")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Surname is required")]
        [RegularExpression(@"^[a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ]+$", ErrorMessage = "Surname must contain only letters")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Surname must be between 2 and 2 characters")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Nationality is required")]
        [RegularExpression(@"^[a-zA-ZąćęłńóśźżĄĆĘŁŃÓŚŹŻ]+$", ErrorMessage = "Nationality must contain only letters")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Nationality must be between 2 and 25 characters")]
        public string Nationality { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(18, int.MaxValue, ErrorMessage = "Age must be 18 or older")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Hire Date is required")]
        [DataType(DataType.Date, ErrorMessage = "Invalid Date format")]
        public DateTime HireDate { get; set; }
    }
}
