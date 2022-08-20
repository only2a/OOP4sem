using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Storekeeper
    {
        public string FIO { get; set; }
        public string Adress { get; set; }
        public int Experience { get; set; }


        public Storekeeper()
        {

        }


        public Storekeeper(string FIO, string adress, int Experience)
        {
            this.FIO = FIO;
            Adress = adress;
            this.Experience = Experience;
        }
    }

}
