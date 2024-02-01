using System;
using System.Threading.Tasks.Dataflow;

//Exceeding Requirements: 
//Added a feature to allow the user to either enter a number or the option's name in the main menu
//Added an option to delete a file
//Added more prompts for the user to respond to

namespace JournalProgram {
    class Program {
        static void Main(string[] args) {
            Journal MyJournal = new Journal();
            string choice = "";

            Console.WriteLine("Welcome to the Journal Program!");

            while (choice != "6" && choice.ToLower() != "quit") {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1. Write Entry");
                Console.WriteLine("2. Display Entries");
                Console.WriteLine("3. Save Journal");
                Console.WriteLine("4. Load Journal");
                Console.WriteLine("5. Delete File");
                Console.WriteLine("6. Quit");
                
                choice = Console.ReadLine();

                if (choice == "1" || choice.ToLower() == "write entry") {
                    MyJournal.NewEntry();
                }
                else if (choice == "2" || choice.ToLower() == "display entries") {
                    MyJournal.ShowHistory();
                }
                else if (choice == "3" || choice.ToLower() == "save journal") {
                    MyJournal.SaveFile();
                }
                else if (choice == "4" || choice.ToLower() == "load journal") {
                    MyJournal.LoadFile();
                }
                else if (choice == "5" || choice.ToLower() == "delete file") {
                    MyJournal.DeleteFile();
                }
                else if (choice == "6" || choice.ToLower() == "quit") {
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
}