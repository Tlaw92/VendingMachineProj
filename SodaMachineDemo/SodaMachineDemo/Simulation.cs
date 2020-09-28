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
        public string userInput;
        public int runningTotal;

        //Constructors (initial values)
        public Simulation()
        {
            sodaMachine = new SodaMachine();
            customer = new Customer();
            runningTotal = 0;
        }

        //Member Methods (Can Do)
        public void RunSimulation()
        {

            UserInterface.Greeting();
            

            while (sodaMachine.CheckTotal() == false)
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                DepositCoin(userInput);
            }
            userInput = UserInterface.DisplayMenu1();
            
            MakeDrinkSelection(userInput);
            double change = sodaMachine.ChangeCalculator();
            sodaMachine.ReturnChange();
            


            Console.ReadLine();
        }

        public void MakeDrinkSelection(string selection)
        {
            bool selectionOK = false;
            while (!selectionOK)
            {
                switch (selection)
                {
                    case "A1":
                        UserInterface.ChosenSodaGestureA1();
                        selectionOK = true;
                        sodaMachine.ReturnChange();
                        break;

                    case "B1":
                        UserInterface.ChosenSodaGestureB1();
                        selectionOK = true;
                        sodaMachine.ReturnChange();
                        break;

                    case "C1":
                        UserInterface.ChosenSodaGestureC1();
                        selectionOK = true;
                        sodaMachine.ReturnChange();
                        break;

                    default:
                        UserInterface.InvalidEntry();
                        selection = (Convert.ToString(Console.ReadLine().ToUpper()));
                        selectionOK = false;
                        break;
                }

            }

        }
        public void DepositCoin(int money)
        {
            //the only valid entries are 1, 5, 10, 25, 
            switch (money)
            {
                case (5):
                    sodaMachine.RunningTotal += 5;
                    UserInterface.ConfirmCoin(5);
                    break;
                case (10):
                    sodaMachine.RunningTotal += 10;
                    UserInterface.ConfirmCoin(10);
                    break;
                case (25):
                    sodaMachine.RunningTotal += 25;
                    UserInterface.ConfirmCoin(25);
                    break;
                case (1):
                    sodaMachine.RunningTotal += 1;
                    UserInterface.ConfirmCoin(1);
                    break;
                default:
                    UserInterface.InvalidEntry();
                    break;
            }
            


        }
    }
}
