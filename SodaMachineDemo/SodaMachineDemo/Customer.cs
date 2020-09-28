using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineDemo
{
    // As a Customer, I want to keep track of my Coins in a Wallet class and my Cans in a Backpack
    // class. Backpack should start empty, Wallet should start with at least $5 in mixed change

    // As a Customer, I want to select the coins I’m entering as payment and have them added to a List.

    // I want to choose which soda to be dispensed from the current inventory of the machine.

    // If not enough money is passed, don't complete the transaction and give money back.

    // If exact change is passed in, accept payment and dispense a soda instance that gets saved in my backpack.

    // If too much money is passed in, accept the payment, return change as a list of coins from 
    // internal, limited register, and dispense a soda instance that gets saved to my Backpack.

    // If too much money is passed in but there isn’t sufficient change in the machine’s internal
    // register, don’t complete transaction: give the money back.

    // If exact or too much money is passed in but there isn’t sufficient inventory for that soda, don’t 
    // complete the transaction: give the money back.

    class Customer
    {
        //Member Variables (Has a)
        public Wallet wallet;
        public Backpack cansList;

        //Constructors (initial values)
        public Customer()
        {
            wallet = new Wallet();
            cansList = new Backpack();
        }

        //Member Methods (Can do)
       
    }
}
