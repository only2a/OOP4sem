using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Products
    {
        public List<Product> list;
        public Products()
        {
            list = new List<Product>();
        }

        public string Show()
        {
            string s = "";
            foreach (var el in list)
            {
                s += $"ProductName: {el.Name} || ManufacturerName: {el.Manuf.Organization} || StorekeeperName: {el.storekeeper.FIO} ******";

            }
            return s;
        }

        
    }
}
