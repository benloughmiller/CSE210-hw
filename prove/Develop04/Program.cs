using System;
using System.Runtime.CompilerServices;

//Stretch: The Activity will not allow a user to enter non-integers as the activity duration.
//Stretch: The Breathing Activity allocates the last portion of remaining time to accommodate an even time for inhaling and exhaling.
//Stretch: The Reflecting Activity will not show the same questions twice in the same session.
//Stretch: The Reflecting Activity adjusts the last waiting period to match the remaining activity time.

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
            Console.Write("\nSelect a choice from the menu: ");
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
                Console.Write("Incorrect choice, press 'Enter' to continue.");
                Console.ReadLine();
            }
        }
        Console.Clear();
        Console.WriteLine("Exiting the program.");
        Environment.Exit(0);
    }
}