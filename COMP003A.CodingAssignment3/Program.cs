/*
 Author: Victor Flores
Course: COMP-003A
Faculty: Jonathon Cruz
Purpose: Budget management application demonstrating control flow
*/
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq.Expressions;

namespace COMP003A.CodingAssignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Budget Management Tool!\n");

            int range;

            while (true)
            {
                try
                {
                    Console.Write("Enter your monthly income: ");
                    range = int.Parse(Console.ReadLine());
                    if (range <= 0) throw new Exception("Number must be at least 1.");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Invalid Input: {ex.Message} \nPlease enter a valid income");
                    //user's income 
                }
            }
            
            Console.WriteLine("\nMenu: \n");
            int[] numbers =  { 1, 2, 3, 4};
            int _range;
            while (true)
            {
                try
                {
                    Console.Write("1. Add an Expense: \n");
                    Console.Write("2. View Expenses and Budget: \n");
                    Console.Write("3. Remove an Expense: \n");
                    Console.Write("4. Exit \n");
                    Console.Write("Enter your choice: ");
                    _range = int.Parse(Console.ReadLine());
                    if (_range >= 5) throw new Exception("Number not on menu.");
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nInvalid input: {ex.Message} \nSelect a number on the menu.");
                }
            }

           
            if ( _range == 1)
                {
                Console.Write("Enter the expense name: ");
                Console.ReadLine();
                Console.Write("Enter the expense amount: ");
                Console.ReadLine();
                Console.WriteLine("Expense added successfully");
                }

            if (_range == 2)
            {
                //enter option 2
            }

            if ( _range == 3)
            {
                //enter option 3
            }

            if ( _range == 4)
            {
                //enter option 4
            }

        }
    }
}
