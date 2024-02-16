using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
//Add Difficulty modes?(easy, medium, hard, - more words removed from the verse)
class Program {    
    static void Main(string[] args) {
        string choice = "";
        Scripture scripture = new Scripture();

        Console.WriteLine("Welcome to the Scripture Memorization Program!");
        Console.WriteLine("\nPress enter to begin memorizing a verse or type 'q' or 'quit' to exit the program.");

        while (choice.ToLower() != "q") {
            choice = Console.ReadLine();

            if (choice == "") {
                //Start the program
                Console.Clear();
                scripture.DisplayVerse();
                Console.WriteLine("\nPress enter to continue the program or enter 'q' to exit the program.");
            }
            else {
                Console.WriteLine("Incorrect choice, please try again.");
            }
        }
        Console.WriteLine("Exiting the program");
        Environment.Exit(0);
                
    }
}