using _6_7_8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_7_8.Controllers
{
    public class ProductsController
    {
        public List<Product> list;
        private Stack<Product> history;
        public ProductsController()
        {


            list = new List<Product>();
            history = new Stack<Product>();
        }

        //public void Add(Product product)
        //{
        //    list.Add(product);
        //    Save();
        //}


        public void Remove( Product el)
        {
            history.Push(el);
            list.Remove(el);

        }
        public void GetRedo()
        {
            Product product = history.Pop();
            list.Add(product);
        }
        public void GetProducts()
        {
            list = JsonSerializer.Deserialize<List<Product>>("products.json");
        }

        public void Save()
        {
            JsonSerializer.Serialize(list, "products.json");
        }
    }
}
