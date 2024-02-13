using System;
using System.Runtime.CompilerServices;

class Program {    
    static void Main(string[] args) {
        string choice = "";
        Scripture scripture = new Scripture();

        Console.WriteLine("Welcome to the Scripture Memorization Program!");
        Console.WriteLine("\nPress enter to begin memorizing a verse or type 'q' or 'quit' to exit the program.");

        while (choice.ToLower() != "q" && choice.ToLower() != "quit") {
            choice = Console.ReadLine();

            if (choice == "") {
                //Start the program
                scripture.Convert();
                Console.WriteLine("\nPress enter to continue or type 'q' or 'quit' to exit the program.");
            }
            else {
                Console.WriteLine("Incorrect choice, please try again.");
            }
        }
        Console.WriteLine("Exiting the program");
        Environment.Exit(0);
                
    }
}