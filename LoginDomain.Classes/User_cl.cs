using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginDomain.Classes
{
    public class User_cl
    {
        [Key]
        public Guid UserID { get; set; }
        [Display(Name ="User Name")]
        public string Username { get; set; }
        [Display(Name = "Login Name")]
        public string LoginName { get; set; }
        //For security we can convert pwd into hass so no one can see in database as well.
        //public string HashedPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Pwd { get; set; }

        /*Unnecessory field*/
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
    }
}
