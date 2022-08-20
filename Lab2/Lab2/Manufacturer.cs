using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab2
{
    public class Manufacturer
    {
        public string Organization { get; set; }
        public string Adress { get; set; }
        public string PhoneNumb { get; set; }


        public Manufacturer()
        {
            Organization = "";
            Adress = "";
            PhoneNumb = "";
        }


        public Manufacturer(string organization, string adress, string PhoneNumb)
        {
            Organization = organization;
            Adress = adress;
            this.PhoneNumb = PhoneNumb;
        }
    }
}
