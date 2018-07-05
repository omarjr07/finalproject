using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FinalProjectB.Models
{
    public class Account
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        public string fName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        public string lName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Username is Required")]
        public string Username { get; set; }

        public string role { get; set; }

        [Required(ErrorMessage = "Password Name is required.")]
        [DataType(DataType.Password)]
        public string password { get; set; }


        [Compare("Password", ErrorMessage = "Password doesnt match.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
