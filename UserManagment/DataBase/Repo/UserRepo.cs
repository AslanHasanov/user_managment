using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagment.DataBase.Models;

namespace UserManagment.DataBase.Repo
{
    internal class UserRepo
    {

        private static int _idCounter;

        public static int IdCounter
        {
            get
            {
                _idCounter++;
                return _idCounter;
            }
        }
        public static List<User> Users { get; set; } = new List<User>()
        {
            new Admin("Admin","Super","admin@gmail.com","123321")
           
        };

        public static User AddUser(string firstName, string lastName, string email, string password)
        {
            User user = new User(firstName, lastName, email, password,IdCounter);
            Users.Add(user);
            return user;
        }
        public static User AddUser(string firstName, string lastName, string email, string password, int id)
        {
            User user = new User(firstName, lastName, email, password, id);
            Users.Add(user);
            return user;
        }
        public static User AddUser(Admin user)
        {
            Users.Add(user);
            return user;
        }
        public static User AddUser(User user)
        {
            Users.Add(user);
            return user;
        }
        public static User UpdateUser(string email,User user)
        {
            User newUser=UserRepo.GetUserByEmail(email);
            newUser.FirstName= user.FirstName;
            newUser.LastName= user.LastName;
            return newUser;
        }
        public static User UpdateAdmin(string email, Admin admin)
        {
            User newUser = UserRepo.GetUserByEmail(email);
            newUser.FirstName = admin.FirstName;
            newUser.LastName = admin.LastName;
            return newUser;
        }
        
        public static List<User> GetAll()
        {
            return Users;
        }

        public static bool IsUserExistsByEmail(string email)
        {
            foreach (User user in Users)
            {
                if (user.Email == email)
                {
                    return true;
                }
            }

            return false;
        }

        public static User GetUserByEmailAndPassword(string email, string password)
        {
            foreach (User user in Users)
            {
                if (user.Email == email && user.Password == password)
                {
                    return user;
                }
            }

            return null;
        }

        public static bool IsUserExistByEmailAndPassword(string email, string password)
        {
            foreach (User user in Users)
            {
                if (user.Email == email && user.Password == password)
                {
                    return true;
                }
            }

            return false; ;
        }

        public static User GetUserByEmail(string email)
        {
            foreach (User user in Users)
            {
                if (user.Email == email)
                {
                    return user;
                }
            }

            return null;
        }

        public static void Delete(User user)
        {
            Users.Remove(user);
        }

    }
}
