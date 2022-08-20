using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    [DataContract]
    public class Product
    {

        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Number { get; set; }
        [DataMember]
        public double Weight { get; set; }
        [DataMember]
        public double Height { get; set; }
        [DataMember]
        public Type type { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public int Count { get; set; }
        [DataMember]
        public double Price { get; set; }
        [DataMember]
        public Manufacturer Manuf { get; set; }
        [DataMember]
        public Storekeeper storekeeper { get; set; }
        [DataMember]
        public string dopInf { get; set; }




        public enum Type
        {
            technical,
            office,
            furniture
        }


        public Product() { }
        public Product(string Name, int number, double Weight, double Height, Type type, DateTime Date, int count, double price, Manufacturer manuf, Storekeeper storekeeper,string dopInf)
        {
            this.Name = Name;
            Number = number;
            this.Weight = Weight;
            this.Height = Height;
            this.type = type;
            this.Date = Date;
            Count = count;
            Price = price;
            Manuf = manuf;
            this.storekeeper = storekeeper;
            this.dopInf = dopInf;
        }

    }

}
