using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineDemo
{
    class SodaMachine
    {
        List<Coin> register;
        List<Can> inventory;

        public SodaMachine()
        {
            register = new List<Coin>();
            inventory = new List<Can>();

        }


        //If enough money is not passed in, don’t complete transaction and give the money back. 

        public bool EnoughMoneyForPurchase(double moneyCustomerPaid, Can canSelected)
        {
            if(moneyCustomerPaid > canSelected.Cost)
            {
                return true;
            }
            return false;
        }

        public void ReturnMoneyToCustomer(List<Coin> coinsGivenByCustomer, Customer customer)
        {
            customer.wallet.coins.AddRange(coinsGivenByCustomer);
        }




    }
}
