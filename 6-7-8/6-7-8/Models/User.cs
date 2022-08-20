using _6_7_8.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _6_7_8.Models
{
    [DataContract]
    public class User
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public List<Product> boughtProducts;
        [DataMember]
        public bool IsCurrent;

        private const string AdminPassw = "312890";


        public User(string name, string password)
        {
            Name = name;
            Password = password;
            boughtProducts = new List<Product>();
        }

        public User(string name, string password, bool IsCurrent)
        {
            Name = name;
            Password = password;
            this.IsCurrent = IsCurrent;
            boughtProducts = new List<Product>();

        }

        public override string ToString()
        {
            return Name;
        }

        public bool IsAdmin()
        {
            if (this.Name == "Admin" && this.Password == AdminPassw)
            {
                return true;
            }
            else return false;
        }

        

    }
}
