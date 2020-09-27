using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineDemo
{
    class Simulation
    {
        //Member Variables
        SodaMachine sodaMachine;
        Customer customer;

        //Constructors (initial values)
        public Simulation()
        {
            sodaMachine = new SodaMachine();
            customer = new Customer();
        }

        //Member Methods (Can Do)
        public void RunSimulation()
        {

            UserInterface.Greeting();








            Console.ReadLine();







            //SodaMachine sodaMachine = new SodaMachine();

            //while (!sodaMachine.CheckTotal())
            //{
            //    Console.WriteLine("All soda costs 1 dollar" + "\n" + "Please enter coin amount or a dollar bill amount (5, 10, 25, 100)");
            //    sodaMachine.DepositCoin(Convert.ToInt32(Console.ReadLine()));
            //}
            //sodaMachine.DisplayDrinkSelections();

            //Console.ReadLine();
        }
    }
}
