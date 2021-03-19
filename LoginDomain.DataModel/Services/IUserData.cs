using System.Collections.Generic;
using LoginDomain.Classes;

namespace LoginDomain.DataModel.Services
{
    public interface IUserData
    {
        void Add(User_cl user);
        User_cl Get(string userName);
        IEnumerable<User_cl> GetAll();
        void Update(User_cl user);
    }



}
