using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args) {
        ActivityManager activityManager = new ActivityManager();

        string _choice = "";
        while (_choice != "6") {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Run an Activity");
            Console.WriteLine("    2. List Activty History");
            Console.WriteLine("    3. View Activity Statistics");
            Console.WriteLine("    4. Read Activity from File");
            Console.WriteLine("    5. Write Activity to File");           
            Console.WriteLine("    6. Quit");
            Console.Write("\nSelect a choice from the menu: ");
            _choice = Console.ReadLine();

            if (_choice == "1") {
                string _activityChoice = "";
                Console.WriteLine("Choose an Activity:");
                Console.WriteLine("    1. Coin Flip");
                Console.WriteLine("    2. Spinner Wheel");
                Console.WriteLine("    3. Dice Roll");
                Console.WriteLine("    4. Draw Card");
                _activityChoice = Console.ReadLine();
                
                while (_activityChoice != "1" && _activityChoice != "2" && _activityChoice != "3" && _activityChoice != "4") {
                    Console.Write("Incorrect Choice. Please enter a valid entry: ");
                    _activityChoice = Console.ReadLine();
                }
                activityManager.NewActivity(int.Parse(_activityChoice));
            }
            else if (_choice == "2") {

            }
            else if (_choice == "3") {
    
            }
            else if (_choice == "4") {
    
            }
            else if (_choice == "5") {
    
            }
            else if (_choice == "6") {
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