using _6_7_8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_7_8.Patterns
{
    abstract class ProductStringBuilder
    {
        public ProductInforamation info = new ProductInforamation();
        public void CreateStudentStringInfo()
        {
            info = new ProductInforamation();
        }
        public abstract void BuildProductLaptopInformation(Product p);
        public abstract void BuildProductPhoneInformation(Product p);

    }

    public class ProductLaptopInformation
    {
        public string shortName { get; set; }
        public string typeOfProduct { get; set; }

        public string screenSize { get; set; }

        public string screenType { get; set; }

        public string cpu { get; set; }

        public string RAM { get; set; }

        public string graphicsCardModel { get; set; }
        public string discription { get; set; }

        public string price { get; set; }

        public string result { get; set; }


    }

    public class ProductPhoneInformation
    {
        public string shortName { get; set; }
        public string typeOfProduct { get; set; }

        public string screenSize { get; set; }

        public string screenType { get; set; }

        public string cpu { get; set; }

        public string RAM { get; set; }

        public string numberOfSIM { get; set; }

        public string operatingSystem { get; set; }

        public string cameraResolutions { get; set; }
        public string discription { get; set; }

        public string price { get; set; }

        public string result { get; set; }



    }

    public class ProductInforamation
    {
        public ProductLaptopInformation ProductLaptopINFO { get; set; }
        public ProductPhoneInformation ProducPhoneINFO { get; set; }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (ProductLaptopINFO != null)
            {
                sb.Append("Наименование товара: " + ProductLaptopINFO.shortName +
                           "\nТип товара: " + ProductLaptopINFO.typeOfProduct +
                           "\nРазмер экрана: " + ProductLaptopINFO.screenSize +
                           "\nТип матрицы: " + ProductLaptopINFO.screenType +
                           "\nПроцессор: " + ProductLaptopINFO.cpu +
                           "\nВидеокарта: " + ProductLaptopINFO.graphicsCardModel +
                           "\nОперативная память: " + ProductLaptopINFO.RAM +
                           "\nОбъём ЖД: " + ProductLaptopINFO.result +
                           "\nЦена: " + " $" + ProductLaptopINFO.price +
                           "\nОписание: " + ProductLaptopINFO.discription);
            }

            if (ProducPhoneINFO != null)
            {
                sb.Append("Наименование товара: " + ProducPhoneINFO.shortName +
                           "\nТип товара: " + ProducPhoneINFO.typeOfProduct +
                           "\nРазмер экрана: " + ProducPhoneINFO.screenSize +
                           "\nТип матрицы: " + ProducPhoneINFO.screenType +
                           "\nПроцессор: " + ProducPhoneINFO.cpu +
                           "\nВидеокарта: " + ProducPhoneINFO.numberOfSIM +
                           "\nВидеокарта: " + ProducPhoneINFO.operatingSystem +
                           "\nВидеокарта: " + ProducPhoneINFO.cameraResolutions +
                           "\nОперативная память: " + ProducPhoneINFO.RAM +
                           "\nОбъём ЖД: " + ProducPhoneINFO.result +
                           "\nЦена: " + "$" + ProducPhoneINFO.price +
                           "\nОписание: " + ProducPhoneINFO.discription);
            }

            return sb.ToString();
        }
    }


    class LaptopInformationBuilder : ProductStringBuilder
    {








        public override void BuildProductLaptopInformation(Product p)
        {
            info.ProductLaptopINFO = new ProductLaptopInformation();
            info.ProductLaptopINFO.shortName = p.shortName;
            info.ProductLaptopINFO.typeOfProduct = p.typeOfProduct;
            info.ProductLaptopINFO.screenSize = p.screenSize;
            info.ProductLaptopINFO.screenType = p.screenType;
            info.ProductLaptopINFO.cpu = p.cpu;
            info.ProductLaptopINFO.graphicsCardModel = p.graphicsCardModel;
            info.ProductLaptopINFO.RAM = p.RAM;
            info.ProductLaptopINFO.result = p.result;
            info.ProductLaptopINFO.price = p.price;
            info.ProductLaptopINFO.discription = p.discription;


        }

        public override void BuildProductPhoneInformation(Product p)
        {

        }
    }

    class PhoneInformationBuilder : ProductStringBuilder
    {
        public override void BuildProductLaptopInformation(Product p)
        {

        }


        public override void BuildProductPhoneInformation(Product p)
        {
            info.ProducPhoneINFO = new ProductPhoneInformation();
            info.ProducPhoneINFO.shortName = p.shortName;
            info.ProducPhoneINFO.typeOfProduct = p.typeOfProduct;
            info.ProducPhoneINFO.screenSize = p.screenSize;
            info.ProducPhoneINFO.screenType = p.screenType;
            info.ProducPhoneINFO.cpu = p.cpu;
            info.ProducPhoneINFO.numberOfSIM = p.numberOfSIM;
            info.ProducPhoneINFO.operatingSystem = p.operatingSystem;
            info.ProducPhoneINFO.cameraResolutions = p.cameraResolutions;
            info.ProducPhoneINFO.RAM = p.RAM;
            info.ProducPhoneINFO.result = p.result;
            info.ProducPhoneINFO.price = p.price;
            info.ProducPhoneINFO.discription = p.discription;
        }
    }


    class ProductManager
    {
        public ProductInforamation BuildString(ProductStringBuilder productStringBuilder, Product p)
        {
            productStringBuilder.BuildProductLaptopInformation(p);
            productStringBuilder.BuildProductPhoneInformation(p);

            return productStringBuilder.info;
        }
    }
}
