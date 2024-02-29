using System;
using System.Runtime.CompilerServices;

class Program {
    static void Main(string[] args) {
        string _choice = "";
        while (_choice != "4") {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("    1. Start Breathing Activity");
            Console.WriteLine("    2. Start Reflecting Activity");
            Console.WriteLine("    3. Start Listing Activity");
            Console.WriteLine("    4. Quit");
            Console.WriteLine("\n Select a choice from the menu: ");
            _choice = Console.ReadLine();

            if (_choice == "1") {
                BreathingActivity breathing = new BreathingActivity();
                breathing.RunBreathing();      
            }
            else if (_choice == "2") {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.RunReflecting();  
            }
            else if (_choice == "3") {
                ListingActivity listing = new ListingActivity();
                listing.RunListing();      
            }
            else if (_choice == "4") {
                break; 
            }
            else {
                Console.WriteLine("Incorrect choice, please try again.");
            }
        }
        Console.WriteLine("Exiting the program");
        Environment.Exit(0);
    }
}