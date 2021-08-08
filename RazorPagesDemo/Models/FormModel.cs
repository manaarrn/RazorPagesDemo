using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace RazorPagesDemo.Models
{
    public class FormModel
    {
        [StringLength(20, ErrorMessage = "First name is required")]
        [Required]
        public string FirstName { get; set; }
        [StringLength(20, ErrorMessage = "Last name is required")]
        [Required]
        public string LastName { get; set; }
        [EmailAddress(ErrorMessage = "Email address is required")]
        [Required]
        public string Email { get; set; }
        [StringLength( 60 , ErrorMessage ="University name is required", MinimumLength = 3)]
        [Required]
        public string UniName { get; set; }
        [Required(ErrorMessage = "Date of birth is required")]
        public DateTime BirthDate { get; set; }

    }
}
