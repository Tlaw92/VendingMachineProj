using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineDemo
{
    class Quarter : Coin
    {
        public Quarter()
        {
            name = "Quarter";
            value = .25;
        }
    }
}
