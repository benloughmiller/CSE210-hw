using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

//Stretch: Added List of verses/references to be drawn from
//Stretch: If a word is hidden, the program displays the word with each individual letter replaced by underscores
//Stretch: Added difficulty levels for the user to choose from
//Stretch: Made it so that if a word is already hidden, the hide constructor will try a different word
class Program {    
    static void Main(string[] args) {
        Scripture scripture = new Scripture();

        Console.WriteLine("Welcome to the Scripture Memorization Program!");
        Console.WriteLine("Please select a difficulty level: Type 1 for easy, 2 for normal, 3 for hard.");
        
        int _difficulty = 0;
        int _userDifficulty = int.Parse(Console.ReadLine());
        if (_userDifficulty == 1){
            _difficulty = 1;
        }
        else if (_userDifficulty == 2){
            _difficulty = 3;
        }
        else if (_userDifficulty == 3){
            _difficulty = 5;
        }

        Console.Clear();
        Console.WriteLine("\nPress enter to begin memorizing a verse or 'q' to exit the program.");
        string choice = Console.ReadLine();

        while (choice.ToLower() != "q") {

            if (choice == "") {
                Console.Clear();
                scripture.DisplayVerse();
                Console.WriteLine("\n\nPress 'Enter' to continue the program or 'q' to exit the program.");
                choice = Console.ReadLine();
                scripture.HideWord(_difficulty);
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