using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineDemo
{
    class Wallet
    // I want to keep track of my Coins in a Wallet class
    // Wallet should start with at least $5 in mixed change
    {
        //Member Variables (Has a)
        public List<Coin> coins;

        //Constructors (initial values)

        public Wallet()
        {
            coins = new List<Coin>();
        }

        //Member Methods (Can do)

    }
}
