using Lab4.Patterns;
using Lab5.Patterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    [DataContract]
    public class Product:Prototype
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

        public Inspectorro inspectorro;


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


        public Product(string Name, int number, double Weight, double Height, Type type, DateTime Date, int count, double price, Manufacturer manuf, Storekeeper storekeeper, string dopInf, AbstractFactory abstractFactory)
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
            inspectorro = abstractFactory.CreateInspect();
        }

        public static string New(Facade facade)
        {
           return facade.NewProduct();
        }
        public static string RFS(Facade facade)
        {
           return facade.RemoverFromSale();
        }


        public override Prototype Clone()
        {
            if (this.inspectorro.checkedOrNo == "Проверен")
            {
                return new Product( Name,  Number,  Weight,  Height,  type,  Date,  Count,  Price,  Manuf,  storekeeper,  dopInf, new InspectedProductFactory());
            }
            else if (this.inspectorro.checkedOrNo == "Не проверен")
            {
                 return new Product(Name, Number, Weight, Height, type, Date, Count, Price, Manuf, storekeeper, dopInf, new UntestedProductFactory());
            }
            return new Product(Name, Number, Weight, Height, type, Date, Count, Price, Manuf, storekeeper, dopInf);
        }



        public string dealCompleted()
        {
            return "Сделка выполнена. Товар продан!";
        }
        public string dealNotCompleted()
        {
            return "Сделка не выполнена. Товар не продан!";
        }
    }

}
