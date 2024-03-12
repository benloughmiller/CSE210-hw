using System;

class Program {
    static void Main(string[] args) {
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
                string _goalChoice = "";
                while (_goalChoice != "4") {
                    Console.WriteLine("The types of Goals are:");
                    Console.WriteLine("    1. Simple Goal");
                    Console.WriteLine("    2. Eternal Goal");
                    Console.WriteLine("    3. Checklist Goal");
                    Console.WriteLine("    4. Quit");
                    Console.Write("\nWhich type of goal would you like to create? ");
                    _goalChoice = Console.ReadLine(); 

                    if (_choice == "1") {
                    }
                    else if (_choice == "2") {
                    }
                    else if (_choice == "3") {   
                    }
                    else if (_choice == "4") {
                        break;   
                    }
                    else {
                        Console.Write("Incorrect choice, press 'Enter' to continue.");
                        Console.ReadLine();
                    }
                }
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
    }    }
}