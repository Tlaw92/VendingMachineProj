using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SodaMachineDemo
{
    //allow the user to be prompted to type in selections.
    //All Console interactions(ReadLines and WriteLines) should be in this class.    

    //  I need to figure out how display greeting and also the varieties of soda and their cost.

    static class UserInterface
    {
        //Member Variables (Has a)
        public static List<string> sodaList;
        public static string userInput;



        //Member Methods (Can do)
        public static void Greeting()
        {
            Console.WriteLine("Hello customer! Insert 100 cents to buy a Pop\n");
            Console.WriteLine("Type 25 to insert a quarter, type 10 to insert dimes, type 5 to insert nickles, and type 1 to insert pennies");
            
        }

        

        public static void DisplayMenu1()
        {
            Console.WriteLine(
                "Type A1 for Cola\n" +
                "Type B1 for Root Beer\n" +
                "Type C1 for Orange Soda");
            
        }

        public static void ChosenSodaA1()
        {
            Console.WriteLine("Thank you for choosing Cola");
        }
        public static void ChosenSodaB1()
        {
            Console.WriteLine("Thank you for choosing Root Beer");
        }
        public static void ChosenSodaC1()
        {
            Console.WriteLine("Thank you for choosing Orange Soda");
        }

        public static void ConfirmCoin(int Int)
        {
            Console.WriteLine($"You have entered {Int} cents");
        }

        //public static List<string> SodaList()
        //{
        //    sodaList = new List<string>();
        //    sodaList.Add("Cola");
        //    sodaList.Add("Root Beer");
        //    sodaList.Add("Orange Soda");
        //    return sodaList;
        //}

        public static void InvalidEntry()
        {
            Console.WriteLine("Invalid Selection. Please try again:");
        }

    }
}
