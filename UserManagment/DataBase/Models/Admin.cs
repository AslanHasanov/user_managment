using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagment.DataBase.Models
{
    class Admin: User
    {
        public Admin(string firstName, string lastName, string email, string password, int id)
           : base(firstName, lastName, email, password, id)
        {


        }
        public Admin(string firstName, string lastName, string email, string password)
            : base(firstName, lastName, email, password)
        {
        }
        public Admin(string firstName, string lastName):base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }


        public override string GetInfo()
        {
            return $"Hello admin {FirstName} {LastName} {_registerTime}";
        }
    }
}
