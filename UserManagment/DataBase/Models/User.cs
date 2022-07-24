using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagment.DataBase.Repo;

namespace UserManagment.DataBase.Models
{
    internal class User
    {
        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        

        public DateTime _registerTime;

        public User(string firstName, string lastName, string email, string password, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Id = id;
        }
        public User(string firstName,string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public User(string firstName, string lastName, string email, string password)
        {

            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Id = UserRepo.IdCounter;
            _registerTime = DateTime.Now;

        }
        public virtual string GetInfo()
        {
            return $"Hello user {FirstName} {LastName} {_registerTime}";
        }
        public string GetUserInfo()
        {
            return $"Hello user {FirstName} {LastName} {_registerTime} {Email}";
        }
    }
}

