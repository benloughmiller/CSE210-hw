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
                Console.Clear();
                Console.WriteLine("Activity Options:");
                Console.WriteLine("    1. Coin Flip");
                Console.WriteLine("    2. Spinner Wheel");
                Console.WriteLine("    3. Dice Roll");
                Console.WriteLine("    4. Draw Card");
                Console.Write("\nWhich activity would you like to run: ");
                string activityChoice = Console.ReadLine();

                while (activityChoice != "1" && activityChoice != "2" && activityChoice != "3" && activityChoice != "4") {
                    Console.Write("Incorrect Choice. Please enter a valid entry: ");
                    activityChoice = Console.ReadLine();
                }
                Console.Write("\nHow many times would you like to run the activity? ");
                int.TryParse(Console.ReadLine(), out int runAmount);
                
                activityManager.NewActivity(int.Parse(activityChoice), runAmount);
            }
            else if (choice == "2") {

            }
            else if (choice == "3") {
    
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