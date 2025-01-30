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

           
            
            
            int[] numbers =  { 1, 2, 3, 4};
            int _range;
            
                Console.WriteLine("\nMenu: \n");


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

            string expenseName1;
            string expenseName2;
            string expenseName3;
            string expenseName4;
            string expenseName5;
            int expenseValue1;
            int expenseValue2;
            int expenseValue3;
            int expenseValue4;
            int expenseValue5;


            if (_range == 1)
                while (true)
                {
                    Console.Write("Enter the expense name: ");
                    expenseName1 = Console.ReadLine();
                    Console.Write("Enter the expense amount: ");
                    expenseValue1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter another expense? (yes/no)");
                    string otherExp = Console.ReadLine().ToLower();
                    // first expense

                    if (otherExp == "yes")
                    {
                        Console.Write("Second expense name: ");
                        expenseName2 = Console.ReadLine();
                        Console.Write("Second expense value: ");
                        expenseValue2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter another expense? (yes/no)");
                        string otherExp2 = Console.ReadLine().ToLower();
                        //second expense
                        if (otherExp2 == "yes")
                        {
                            Console.Write("Third expense name: ");
                            expenseName3 = Console.ReadLine();
                            Console.Write("Third expense value: ");
                            expenseValue3 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter another expense? (yes/no)");
                            string otherExp3 = Console.ReadLine().ToLower();
                            //fourth expense
                            if (otherExp3 == "yes")
                            {
                                Console.Write("Fourth expense name: ");
                                expenseName4 = Console.ReadLine();
                                Console.Write("Fourth expense value: ");
                                expenseValue4 = int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter another expense? (yes/no)");
                                string otherExp4 = Console.ReadLine().ToLower();
                                //fifth expense

                                    if (otherExp4 == "yes")
                                    {
                                        Console.Write("Fifth expense name: ");
                                        expenseName5 = Console.ReadLine();
                                        Console.Write("Fifth expense Value");
                                        expenseValue5 = int.Parse(Console.ReadLine());
                                        Console.Write("Limit reached. \nGo back to menu");
                                    }

                                    else if (otherExp4 == "no")
                                    {
                                    Console.WriteLine("Expense added successfully!");
                                    break;
                                    }
                                else if (otherExp3 == "no")
                               {
                                 Console.WriteLine("Expense added successfully!");
                                 break;
                               }

                            }
                        else if (otherExp2 == "no")
                           {
                             Console.WriteLine("Expense added successfully");
                             break;
                           }
                        }
                    else if (otherExp == "no")
                      {
                        Console.WriteLine("Expense added successfully");
                        break;
                      }
                        
                    }

                    if (_range == 2)
                    {
                        //enter option 2
                        Console.WriteLine($"Expenses: \n");
                        Console.Write($"-{expenseName1}: ${expenseValue1}\n");
                        Console.Write($"-");

                    }

                    if (_range == 3)
                    {
                        //enter option 3
                        Console.WriteLine("Enter the expense you want to remove: ");
                        
                    }

                    if (_range == 4)
                    {
                        //enter option 4
                        Console.WriteLine("Goodbye!");
                        System.Environment.Exit(0);
                    }
                }
        }
    }
}
