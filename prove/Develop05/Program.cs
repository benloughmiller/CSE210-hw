using System;

class Program {
    static void Main(string[] args) {
        GoalManager goalManager = new GoalManager();
        string _choice = "";

        while (_choice != "6") {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Create New Goal");
            Console.WriteLine("    2. List Goals");
            Console.WriteLine("    3. Save Goals");
            Console.WriteLine("    4. Load Goals");
            Console.WriteLine("    5. Record Event");
            Console.WriteLine("    6. Quit");
            Console.Write("\nSelect a choice from the menu: ");
            _choice = Console.ReadLine();

            if (_choice == "1") {
                goalManager.NewGoal();
            }
            else if (_choice == "2") {
                goalManager.ViewGoals();
            }
            else if (_choice == "3") {   
                goalManager.WriteFile();  
            }
            else if (_choice == "4") { 
                goalManager.LoadFile();
            }
            else if (_choice == "5") {   
            //Call a class constructor to allow the user to accomplish a goal.
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
