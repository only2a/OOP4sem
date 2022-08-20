using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _6_7_8.Models
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public string shortName { get; set; }
        [DataMember]
        public string typeOfProduct { get; set; }
        [DataMember]
        public string screenSize { get; set; }
        [DataMember]
        public string screenType { get; set; }
        [DataMember]
        public string cpu { get; set; }
        [DataMember]
        public string RAM { get; set; }
        [DataMember]
        public List<string> storageCapacity { get; set; } = new List<string>();
        [DataMember]
        public string graphicsCardModel { get; set; }
        [DataMember]
        public string numberOfSIM { get; set; }
        [DataMember]
        public string operatingSystem { get; set; }
        [DataMember]
        public string cameraResolutions { get; set; }
        [DataMember]
        public string discription { get; set; }
        [DataMember]
        public string price { get; set; }
        [DataMember]
        public string result { get; set; }
        [DataMember]
        public string imgPath { get; set; }

        /// <summary>
        /// for laptops
        /// </summary>
        /// <param name="typeOfProduct"></param>
        /// <param name="shortName"></param>
        /// <param name="screenSize"></param>
        /// <param name="cpu"></param>
        /// <param name="RAM"></param>
        /// <param name="storageCapacity"></param>
        /// <param name="discription"></param>
        /// <param name="price"></param>
        public Product(string typeOfProduct, string shortName, string screenSize, string screenType, string cpu, string RAM, string graphicsCardModel, List<string> storageCapacity, string discription, string price, string imgstr)
        {
            this.shortName = shortName;
            this.typeOfProduct = typeOfProduct;
            this.screenSize = screenSize;
            this.screenType = screenType;
            this.cpu = cpu;
            this.RAM = RAM;
            this.graphicsCardModel = graphicsCardModel;
            this.storageCapacity = storageCapacity;
            this.discription = discription;
            this.price = price;
            imgPath = imgstr;
        }
        /// <summary>
        /// for Mobile
        /// </summary>
        /// <param name="typeOfProduct"></param>
        /// <param name="shortName"></param>
        /// <param name="screenSize"></param>
        /// <param name="screenType"></param>
        /// <param name="cpu"></param>
        /// <param name="RAM"></param>
        /// <param name="storageCapacity"></param>
        /// <param name="discription"></param>
        /// <param name="price"></param>
        public Product(string typeOfProduct, string shortName, string screenSize, string screenType, string numberOfSIM, string operatingSystem, string cameraResolutions, string cpu, string RAM, List<string> storageCapacity, string discription, string price, string imgstr)
        {
            this.shortName = shortName;
            this.typeOfProduct = typeOfProduct;
            this.screenSize = screenSize;
            this.numberOfSIM = numberOfSIM;
            this.operatingSystem = operatingSystem;
            this.cameraResolutions = cameraResolutions;
            this.screenType = screenType;
            this.cpu = cpu;
            this.RAM = RAM;
            this.storageCapacity = storageCapacity;
            this.discription = discription;
            this.price = price;
            imgPath = imgstr;
        }
        public Product()
        {

        }
        public void ShowList()
        {

            foreach (var el in storageCapacity)
            {
                result += el + " || ";
            }

        }
    }
}
