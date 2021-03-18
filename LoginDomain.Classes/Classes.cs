using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LoginDomain.Classes
{

    //Can Define more classes

    //POCO - Plain odd class object


    //We can consider as Entity as well.
    public class Users
    {
        [Key]
        public Guid UserID { get; set; }
        public string Username { get; set; }
        public string LoginName { get; set; }
        //For security we can convert pwd into hass so no one can see in database as well.
        //public string HashedPassword { get; set; }
        public string Pwd { get; set; }

        /*Unnecessory field*/
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public System.DateTime DateOfBirth { get; set; }

    }


    public class UserRole
    {
        [Key]
        public Guid Id { get; set; }
        public string RoleName { get; set; }

        [Required]
        public Users User { get; set; }
    }



    /*****************************************************************************************
     * So what we have now is hwo Ef infer its model but further also how it can affect the interpretation of the model. 
     * 
     * EF follow these rules all the way to the database and will infer/accept the database has the same rule.
     * 
    *****************************************************************************************/
}
