using System;
using System.Collections.Generic;
using System.Linq;
using LoginDomain.Classes;

namespace LoginDomain.DataModel.Services
{
    public class InMemoryUserData : IUserData
    {

        List<User_cl> user_Cls;

        public InMemoryUserData()
        {
            user_Cls = new List<User_cl>()
            {
                new User_cl { UserID = Guid.NewGuid() , Username = "vang", FirstName = "Vish", LastName = "P", LoginName = "vang" , Email = "v@gmail.com", Pwd = "123456" , DateOfBirth = new DateTime(1980,01,03) , PhoneNumber = "1234567890" },
                new User_cl { UserID = new Guid("ce585d55-2e5d-474b-9b41-ba3a4a9be5e6"), Username = "angle", FirstName = "Angle", LastName = "A", LoginName = "ang", Email = "a@gmail.com", Pwd = "123456", DateOfBirth = new DateTime(1980, 01, 03), PhoneNumber = "1234567890" }
            };
        }
        public User_cl Get(Guid id)
        {
            return user_Cls.FirstOrDefault(u => u.UserID == id);
        }

        public IEnumerable<User_cl> GetAll()
        {
            return user_Cls.OrderBy(r => r.Username) ;
        }

        public void Add(User_cl user)
        {
            //Local Data - List of User - Just for testing purpose. Will be lost once application close. 
            user_Cls.Add(user);
            user.UserID = new Guid();
        }

        public User_cl Get(string userName)
        {
            throw new NotImplementedException();
        }

        public void Update(User_cl user)
        {
            var existing = Get(user.UserID);
            if (existing != null)
            {
                existing.Username = user.Username;
                existing.FirstName = user.FirstName;
                existing.LastName = user.LastName;
                existing.LoginName = user.LoginName;
                existing.Pwd = user.Pwd;
                existing.PhoneNumber = user.PhoneNumber;
                existing.Email = user.Email;
                existing.DateOfBirth = user.DateOfBirth;
            }
        }

       
    }
}
