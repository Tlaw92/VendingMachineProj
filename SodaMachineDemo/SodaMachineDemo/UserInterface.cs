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
            Console.WriteLine("Hello customer! Which Soda would you like to purchase?\n");
            DisplayMenu1();
        }

        public static void DisplayMenu1()
        {
            Console.WriteLine(
                "Type A1 for Cola\n" +
                "Type B1 for Root Beer\n" +
                "Type C1 for Orange Soda");
            userInput = Console.ReadLine();
        }



        //public static List<string> SodaList()
        //{
        //    sodaList = new List<string>();
        //    sodaList.Add("Cola");
        //    sodaList.Add("Root Beer");
        //    sodaList.Add("Orange Soda");
        //    return sodaList;
        //}



    }
}
