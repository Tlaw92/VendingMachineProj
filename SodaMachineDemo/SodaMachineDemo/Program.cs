using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulation sim1 = new Simulation();

            sim1.RunSimulation();
           

        }
        //SodaMachine testMachine = new SodaMachine();
        //Customer testCustomer = new Customer();
        //double testDouble = .20;
        //Can testCan = new OrangeSoda();
        //List<Coin> testList = new List<Coin> { new Quarter(), new Dime() };

        //bool enoughMoneyForPurchase = testMachine.EnoughMoneyForPurchase(testDouble, testCan);
        //testMachine.ReturnMoneyToCustomer(testList, testCustomer);
    }
}
