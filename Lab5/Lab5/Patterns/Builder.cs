using Lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4.Patterns
{
    abstract class ProductStringBuilder
    {
        public ProductInforamation info = new ProductInforamation();
        public void CreateStudentStringInfo()
        {
            info = new ProductInforamation();
        }
        public abstract void BuildProductPrivateInformation(Product p);
        public abstract void BuildProductGeneralInformation(Product p);
        public abstract void BuildProductManufacturerInformation(Product p);
        public abstract void BuildProductStorekeeperInformation(Product p);
    }

    public class ProductPrivateInformation
    {
        public string NameINFO { get; set; }
        public string NumberINFO { get; set; }
        public string TypeInfo { get; set; }
        
    }
    public class ProductGeneralInformation
    {
        public string WidthINFO { get; set; }
        public string HeightINFO { get; set; }
        public string CountINFO { get; set; }
        public string PriceINFO { get; set; }
        public string DateINFO { get; set; }

        
    }
    public class ProductManufacturerInformation
    {
        public string ManufNameINFO { get; set; }
        public string ManufAdressINFO { get; set; }
        public string ManufPhoneNumberINFO { get; set; }
       
    }

    public class ProductStorekeeperInformation
    {
        public string StorekeeperNameINFO { get; set; }
        public string StorekeeperAdressINFO { get; set; }
        public string StorekeeperExpINFO { get; set; }

    }


    public class ProductInforamation
    {
        public ProductPrivateInformation ProductPrivateINFO { get; set; }
        public ProductGeneralInformation ProductGeneralINFO { get; set; }
        public ProductManufacturerInformation ProductManufacturerINFO { get; set; }
        public ProductStorekeeperInformation ProductStorekeeperINFO { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (ProductPrivateINFO != null)
            {
                sb.Append("Наименование товара: " + ProductPrivateINFO.NameINFO +
                           "\nИнвент. номер: " + ProductPrivateINFO.NumberINFO +
                           "\nТип товара: " + ProductPrivateINFO.TypeInfo);
            }

            if (ProductGeneralINFO != null)
            {
                sb.Append("Ширина: " + ProductGeneralINFO.WidthINFO +
                           "\nВысота: " + ProductGeneralINFO.HeightINFO +
                           "\nКоличество: " + ProductGeneralINFO.CountINFO +
                           "\nЦена: " + ProductGeneralINFO.PriceINFO +
                           "\nДата поставки: " + ProductGeneralINFO.DateINFO);
            }

            if (ProductManufacturerINFO != null)
            {
                sb.Append("Организация: " + ProductManufacturerINFO.ManufNameINFO +
                           "\nАдрес главного офиса: " + ProductManufacturerINFO.ManufAdressINFO +
                           "\nНомер: " + ProductManufacturerINFO.ManufPhoneNumberINFO);
            }

            if (ProductStorekeeperINFO != null)
            {
                sb.Append("ФИО кладовщика: " + ProductStorekeeperINFO.StorekeeperNameINFO +
                           "\nАдрес склада: " + ProductStorekeeperINFO.StorekeeperAdressINFO +
                           "\nСтаж кладовщика: " + ProductStorekeeperINFO.StorekeeperExpINFO);
            }

            return sb.ToString();
        }
    }


    class PrivateInformationBuilder : ProductStringBuilder
    {
        public override void BuildProductGeneralInformation(Product p)
        {
           
        }

        public override void BuildProductManufacturerInformation(Product p)
        {
            
        }

        public override void BuildProductPrivateInformation(Product p)
        {
            info.ProductPrivateINFO = new ProductPrivateInformation();
            info.ProductPrivateINFO.NameINFO = p.Name;
            info.ProductPrivateINFO.NumberINFO = p.Number.ToString();
            info.ProductPrivateINFO.TypeInfo = p.type.ToString() ;

        }

        public override void BuildProductStorekeeperInformation(Product p)
        {
           
        }
    }

    class GeneralInformationBuilder : ProductStringBuilder
    {
        public override void BuildProductGeneralInformation(Product p)
        {
            info.ProductGeneralINFO = new ProductGeneralInformation();
            info.ProductGeneralINFO.WidthINFO = p.Weight.ToString();
            info.ProductGeneralINFO.HeightINFO = p.Height.ToString();
            info.ProductGeneralINFO.CountINFO = p.Count.ToString();
            info.ProductGeneralINFO.PriceINFO = p.Price.ToString();
            info.ProductGeneralINFO.DateINFO = p.Date.ToString();

        }

        public override void BuildProductManufacturerInformation(Product p)
        {
            
        }

        public override void BuildProductPrivateInformation(Product p)
        {
            
        }

        public override void BuildProductStorekeeperInformation(Product p)
        {
            
        }

        
    }

    class ManufacturerInformationBuilder : ProductStringBuilder
    {
        public override void BuildProductGeneralInformation(Product p)
        {

        }

        public override void BuildProductManufacturerInformation(Product p)
        {

            info.ProductManufacturerINFO = new ProductManufacturerInformation();
            info.ProductManufacturerINFO.ManufNameINFO = p.Manuf.Organization;
            info.ProductManufacturerINFO.ManufAdressINFO = p.Manuf.Adress;
            info.ProductManufacturerINFO.ManufPhoneNumberINFO = p.Manuf.PhoneNumb.ToString();
           
        }

        public override void BuildProductPrivateInformation(Product p)
        {

        }

        public override void BuildProductStorekeeperInformation(Product p)
        {

        }
    }

    class StorekeeperInformationBuilder : ProductStringBuilder
    {
        public override void BuildProductGeneralInformation(Product p)
        {

        }

        public override void BuildProductManufacturerInformation(Product p)
        {

            

        }

        public override void BuildProductPrivateInformation(Product p)
        {

        }

        public override void BuildProductStorekeeperInformation(Product p)
        {
            info.ProductStorekeeperINFO = new ProductStorekeeperInformation();
            info.ProductStorekeeperINFO.StorekeeperNameINFO = p.storekeeper.FIO;
            info.ProductStorekeeperINFO.StorekeeperAdressINFO = p.storekeeper.Adress;
            info.ProductStorekeeperINFO.StorekeeperExpINFO = p.storekeeper.Experience.ToString();
        }
    }

    class ProductManager
    {
        public ProductInforamation BuildString(ProductStringBuilder productStringBuilder, Product p)
        {
            productStringBuilder.BuildProductPrivateInformation(p);
            productStringBuilder.BuildProductGeneralInformation(p);
            productStringBuilder.BuildProductManufacturerInformation(p);
            productStringBuilder.BuildProductStorekeeperInformation(p);
            return productStringBuilder.info;
        }
    }
}
