using POS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Repository
{
    class UserRepository
    {
        private POSEntities _db;

        public UserRepository()
        {
            _db = new POSEntities();
        }
        public void AddUser(User user)
        {
            _db.Users.Add(user);
            _db.SaveChanges();
        }
        public User GetUser(int userId)
        {
            return _db.Users.FirstOrDefault(c => c.UserId == userId);
        }
        public List<User> GetUsers()
        {
            return _db.Users.ToList();
        }
        public void RemoveUser(int userId)
        {
            var user = _db.Users.FirstOrDefault(c => c.UserId == userId);
            if (user != null)
            {
                _db.Users.Remove(user);
                _db.SaveChanges();
            }

        }
        public User UpdateUser(User user)
        {

            return null;
        }
    }
}
