using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_7_8.Models
{
    static class Params
    {
        public static string shortName { get; set; }

        public static string typeOfProduct { get; set; }

        public static string screenSize { get; set; }

        public static string screenType { get; set; }

        public static string cpu { get; set; }

        public static string RAM { get; set; }

        public static List<string> storageCapacity { get; set; } = new List<string>();

        public static string graphicsCardModel { get; set; }

        public static string numberOfSIM { get; set; }

        public static string operatingSystem { get; set; }

        public static string cameraResolutions { get; set; }

        public static string discription { get; set; }

        public static string price { get; set; }
        public static string imgstr { get; set; }
    }

    static class ParamsForRedoUndo
    {
        public static string shortName { get; set; }

        public static string typeOfProduct { get; set; }

        public static string screenSize { get; set; }

        public static string screenType { get; set; }

        public static string cpu { get; set; }

        public static string RAM { get; set; }

        public static List<string> storageCapacity { get; set; } = new List<string>();

        public static string graphicsCardModel { get; set; }

        public static string numberOfSIM { get; set; }

        public static string operatingSystem { get; set; }

        public static string cameraResolutions { get; set; }

        public static string discription { get; set; }

        public static string price { get; set; }
        public static string imgstr { get; set; }
    }
}
