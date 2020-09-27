using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineDemo
{
    // As a developer, I want my soda machine to start with the following inventory:
    //• Coins: 20 quarters, 10 dimes, 20 nickels, 50 pennies
    //• Cans(you pick how many of each the machine starts with) : 
    //Root Beer(60 cents per can), Cola (35 cents per can), and Orange(6 cents per can)

    class SodaMachine
    {

        //Member Variables (Has A)
        const int CostOfDrink = 100; //CostOfDrink = userinput.Cost
        public int RunningTotal { get; set; }

        public double correctChange;

        //Constructor (Initial Value)
        public SodaMachine()
        {
            RunningTotal = 0;
            correctChange = 0;
        }

        //Member Methods (Can Do)


        //I need a method that tells the user that they havent input enough money and also show how much they have inserted

        public bool CheckTotal()
        {
            if (RunningTotal >= CostOfDrink)
            {
                return true;
            }
            return false;
               
        }

        

        public void ReturnChange()
        {
            if (RunningTotal > CostOfDrink)
                Console.WriteLine($"Your change is {correctChange}");
        }

        public double ChangeCalculator()
        {
           correctChange = (RunningTotal - CostOfDrink) * 0.01;
            return correctChange;
            
        }
    }

























    //Member Variables (Has A)
    //List<Coin> register;
    //List<Can> inventory;

    ////Constructors (initial values)
    //public SodaMachine()
    //{
    //    register = new List<Coin>();
    //    inventory = new List<Can>();

    //}

    //Member Methods (Can Do)


    //If enough money is not passed in, don’t complete transaction and give the money back. 

    //public bool EnoughMoneyForPurchase(double moneyCustomerPaid, Can canSelected)
    //{
    //    if(moneyCustomerPaid > canSelected.Cost)
    //    {
    //        return true;
    //    }
    //    return false;
    //}

    //public void ReturnMoneyToCustomer(List<Coin> coinsGivenByCustomer, Customer customer)
    //{
    //    customer.wallet.coins.AddRange(coinsGivenByCustomer);
    //}




}

