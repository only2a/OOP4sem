using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5.Patterns
{
    public class Facade
    {
        SubSystem subsystemA;
        public Facade(SubSystem sub)
        {
            subsystemA = sub;
        }

        public string NewProduct()
        {
           return subsystemA.operationN();
        }

        public string RemoverFromSale()
        {
            return subsystemA.operation1(); 
        }

    }

   public class SubSystem
    {
        public string operation1()
        {
            return "Товар снят с продажи!\n";
        }

        public string operationN()
        {
            return "Новое поступление!\n";
        }
    }
}
