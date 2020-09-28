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
            FillWalletWithCoins();
        }

        //Member Methods (Can do)

        //create method to initalize wallet. - Done
        //use .Add() to add coins to coins list for the number of coins you want. - Done


        private void FillWalletWithCoins()
        
        {
            for (int i = 0; i <= 16; i++)
            {
                Quarter quarter = new Quarter();
                coins.Add(quarter);
                coins.Add(new Nickel());
            }
            for (int i = 0; i < 10; i++)
            {
                Dime dime = new Dime();
                coins.Add(dime);
            }
            for (int i = 0; i < 50; i++)
            {
                Penny penny = new Penny();
                coins.Add(penny);
            }


        }
    }
}
