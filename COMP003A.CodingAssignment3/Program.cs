/*
 Author: Victor Flores
Course: COMP-003A
Faculty: Jonathon Cruz
Purpose: Budget management application demonstrating control flow
*/
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
            Console.WriteLine("Menu:\n");
            //menu line
            Console.Write("1. Add an Expense:");

            
        }
    }
}
