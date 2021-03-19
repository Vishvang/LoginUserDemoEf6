﻿using System;
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
                new User_cl { UserID = new Guid() , Username = "vang", FirstName = "Vish", LastName = "P", LoginName = "vang" , Email = "v@gmail.com", Pwd = "123456" , DateOfBirth = new DateTime(1980,01,03) , PhoneNumber = "1234567890" },
                new User_cl { UserID = new Guid(), Username = "angle", FirstName = "Angle", LastName = "A", LoginName = "ang", Email = "a@gmail.com", Pwd = "123456", DateOfBirth = new DateTime(1980, 01, 03), PhoneNumber = "1234567890" }
            };
        }

        public IEnumerable<User_cl> GetAll()
        {
            return user_Cls.OrderBy(r => r.Username) ;
        }

        public void Add(User_cl user)
        {
            throw new NotImplementedException();
        }

        public User_cl Get(string userName)
        {
            throw new NotImplementedException();
        }

        public void Update(User_cl user)
        {
            throw new NotImplementedException();
        }
    }
}
