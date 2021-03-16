using System;

namespace LoginDomain.Classes
{

    //Can Define more classes

    //POCO - Plain odd class object

    public class User
    {
        public Guid UserID { get; set; }
        public string Username { get; set; }
        public string LoginName { get; set; }
        //public string HashedPassword { get; set; }
        public string Pwd { get; set; }

        /*Unnecessory field*/
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        
    }

}
