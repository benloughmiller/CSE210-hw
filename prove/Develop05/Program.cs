using System;

class Program {
    static void Main(string[] args) {
        GoalManager goalManager = new GoalManager();
        string _choice = "";
        
        while (_choice != "6") {
            int _totalPoints = goalManager.GetTotalPoints();
            Console.Clear();
            
            Console.WriteLine($"\nYou have {_totalPoints} Points.\n");
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
                Console.WriteLine("Goal Created. Press 'enter' to return to the menu.");
                Console.ReadLine();
            }
            else if (_choice == "2") {
                goalManager.ViewGoals();
                Console.WriteLine("Press 'enter' to return to the menu.");
                Console.ReadLine();
            }
            else if (_choice == "3") {   
                goalManager.WriteFile();
                Console.WriteLine("File saved. Press 'enter' to return to the menu.");
                Console.ReadLine();  
            }
            else if (_choice == "4") { 
                goalManager.LoadFile();
                Console.WriteLine("File loaded. Press 'enter' to return to the menu.");
                Console.ReadLine();
            }
            else if (_choice == "5") {   
                goalManager.GoalProgress();
                Console.WriteLine("Press 'enter' to return to the menu.");
                Console.ReadLine();            
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
