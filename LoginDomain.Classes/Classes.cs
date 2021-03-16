using System;

namespace LoginDomain.Classes
{

    //Can Define more classes

    //POCO - Plain odd class object


    //We can consider as Entity as well.
    public class Users
    {
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
        
    }

}
