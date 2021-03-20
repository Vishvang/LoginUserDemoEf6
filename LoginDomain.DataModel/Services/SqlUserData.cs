using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginDomain.Classes;

namespace LoginDomain.DataModel.Services
{
    public class SqlUserData : IUserData
    {
        private readonly LoginContext db;

        public SqlUserData(LoginContext db)
        {
            this.db = db;
        }

        public void Add(User_cl user)
        {
            db.User.Add(user);
            db.SaveChanges();       //Tell db to execute changes.
        }

        public User_cl Get(string userName)
        {
            return db.User.FirstOrDefault(u => u.Username == userName);
        }

        public User_cl Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User_cl> GetAll()
        {
            return from u in db.User orderby u.FirstName select u;
        }


        public void Update(User_cl user)
        {

            // Optimistic Concurrency Logic - using this we dont need to wory how many users are working on same object.(Locking)
            var entry = db.Entry(user);
            entry.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
