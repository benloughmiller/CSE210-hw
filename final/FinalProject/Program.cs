using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args) {
        ActivityManager activityManager = new ActivityManager();

        string choice = "";
        while (choice != "4") {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Run an Activity");
            Console.WriteLine("    2. List Activty History");
            Console.WriteLine("    3. View Activity Statistics");         
            Console.WriteLine("    4. Quit");
            Console.Write("\nSelect a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1") {
                activityManager.ManagerMenu();
            }
            else if (choice == "2") {
                activityManager.DisplayList();
            }
            else if (choice == "3") {
                ActivityStatistics activityStatistics = new ActivityStatistics(activityManager.GetActivityList());
                activityStatistics.StatisticsMenu();
            }
            else if (choice == "4") {
                break; 
            }
            else {
                Console.Write("Incorrect choice, press 'Enter' to continue.");
                Console.ReadLine();
            }
        }
        Console.Clear();
        Console.WriteLine("Exiting the program.");
        Environment.Exit(0);
    }
}