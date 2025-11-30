using DataLoader.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLoader
{
    internal class DatabaseBrowser
    {

        public static List<User> GetUsers()
        {
            var db = new DatabaseContext();
            var users = db.Users.ToList();
            return users;
        }
    }
}
