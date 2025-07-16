using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCAR
{
    internal class car
    {
        public string carcolor { get; set; }
        public string carmodel { get; set; }
        public string cardate { get; set; }
        public string cargear { get; set; }
        public string carfull()
        {
            return carcolor;
        }
    }
}
