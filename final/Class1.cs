using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors
{
    internal class Hra
    {
        public int Player { get; set; }
        public int Enemy { get; set; }
        public Random generator = new Random();

        public Hra()
        {
            Player = 0;
            Enemy = 0;
        }
    }
}
