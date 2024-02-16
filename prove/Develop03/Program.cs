using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
//Add Difficulty modes?(easy, medium, hard, - more words removed from the verse)
//Stretch: Added List of verses/references to be drawn from
class Program {    
    static void Main(string[] args) {
        Scripture scripture = new Scripture();

        Console.WriteLine("Welcome to the Scripture Memorization Program!");
        Console.WriteLine("\nPress enter to begin memorizing a verse or 'q' to exit the program.");
        string choice = Console.ReadLine();

        while (choice.ToLower() != "q") {

            if (choice == "") {
                //Start the program
                Console.Clear();
                scripture.DisplayVerse();
                Console.WriteLine("\n\nPress 'Enter' to continue the program or 'q' to exit the program.");
                choice = Console.ReadLine();
                //Insert scripture hide word method here
            }
            else {
                Console.Clear();
                Console.WriteLine("Incorrect choice, please press 'Enter' to continue the program or 'q' to exit the program.");
            }
        }
        Console.Clear();
        Console.WriteLine("Exiting the program");
        Environment.Exit(0);
                
    }
}