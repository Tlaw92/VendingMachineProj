using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineDemo
{
    // I want my Coin classes to have a read-only property for double value 
    // (public property & private field for member variable double value).
    class Coin
    {
        //Member Variables (Has a)
        protected double value;
        public string name;
        public double Value
        {
            get
            {
                return value;

            }
        }

        //Member Methods (Can Do)
            
    }
}
