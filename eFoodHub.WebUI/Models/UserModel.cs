using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eFoodHub.WebUI.Models
{
    public class UserModel
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Please Enter Email")]

        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Please provide valid email format")]

        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Name")]

        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Please enter only characters")]



        public string Name { get; set; }


        [Required(ErrorMessage = "Please Enter Password")]

        [RegularExpression("^.*(?=.{8,})(?=.*[a-zA-Z])(?=.*\\d)(?=.*[!#$%&?_@\"]).*$", ErrorMessage = "Password should be atleast Eight combination of A-Z,a-z,0-9,!_@#$%^&*")]

        public string Password { get; set; }


        [Compare("Password", ErrorMessage = "Compare Password doesn't match")]

        public string ConfirmPassword { get; set; }


        [Required(ErrorMessage = "Please Enter Phone Number")]

        [RegularExpression("^(?:(?:\\+|0{0,2})91(\\s*[\\ -]\\s*)?|[0]?)?[789]\\d{9}|(\\d[ -]?){10}\\d$", ErrorMessage = "Please enter valid phone number")]

        public string PhoneNumber { get; set; }

    }
}
