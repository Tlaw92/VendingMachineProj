using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineDemo
{
    class Card
    {
        private double availableFunds;
        public double AvailableFunds
        {
            get
            {
               return availableFunds; 
            }
        }
        public Card()
        {
            availableFunds = 20;
        }
    }
}
