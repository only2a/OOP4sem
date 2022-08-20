using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    
    public static class Information
    {
        public static string name;
        public static int number;
        public static double weight;
        public static double height;
        public static Product.Type _type;
        public static DateTime date;
        public static int count;
        public static float price;
        public static Manufacturer _manufacturer;
        public static Storekeeper _storekeeper;
        public static string dopInf;
    }
    
   
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
