// Author: Manuel Aguilar
// Course: COMP-003A
// Faculty: Jonathan Cruz
// Purpose: Budget management application demonstrating control flow.

namespace COMP003A.CodingAssignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Budget Management Tool!");

            int monthlyIncome = 0;
            int userChoice;
            string expenseName = "";
            int expenseAmount = 0;

            Console.Write("\nEnter your monthly income: ");
            monthlyIncome = int.Parse(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("\nMenu: ");
                Console.WriteLine("1. Add an expense");
                Console.WriteLine("2. View expenses and budget");
                Console.WriteLine("3. Remove an expense");
                Console.WriteLine("4. Exit");
                userChoice = int.Parse(Console.ReadLine());

                if (userChoice == 4)
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }
                else if (userChoice == 1)
                {
                    Console.WriteLine("Enter the expense name: ");
                    expenseName = Console.ReadLine();
                    Console.WriteLine("Enter the expense amount: ");
                    expenseAmount = int.Parse(Console.ReadLine());
                    Console.WriteLine("Expense added successfully");
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine($"Expenses: \n- {expenseName}: ${expenseAmount}");
                    double remainingBudget = monthlyIncome - expenseAmount;
                    Console.WriteLine($"Remaining budget: ${remainingBudget}");
                }
                else if (userChoice == 3)
                {
                    Console.WriteLine("Enter the expense you want to remove: ");
                    string expenseToRemove = Console.ReadLine();
                    if (expenseToRemove == expenseName)
                    {
                        expenseName = "";
                        expenseAmount = 0;
                        Console.WriteLine("Expense removed successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Expense not found");
                    }
                }
                else
                {
                    Console.WriteLine("Please select one of the 4 options on the menu.");
                }
            }
        }
    }
}