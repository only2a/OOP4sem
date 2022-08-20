using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab3
{
    public class Manufacturer
    {
        [RegularExpression(@"(([А-Я][а-я]+(\s?))+$)|([А-Я][а-я]+(-?)([А-Я]?)([а-я]+)$)", ErrorMessage = "Неверно введено название организации!")]
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
