using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineDemo
{
    abstract class Can
    {
        protected double cost;
        public string name;
        public double Cost
        {
            get
            {
                return cost;

            }
        }
    }
}
