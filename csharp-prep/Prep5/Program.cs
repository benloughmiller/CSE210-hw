using System;

class Program
{
    static void Main(string[] args){
        display_welcome();

        string name = prompt_user_name();
        int number = prompt_favorite_number();
        int squared_number = square_number(number);
        display_result(name, squared_number);

        }
        static void display_welcome(){
            Console.WriteLine("Welcome to the program!");
        }

        static string prompt_user_name(){
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            return name;
        }

        static int prompt_favorite_number(){
            Console.WriteLine("What is your favorite number?");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int square_number(int number){
            int square = number * number;
            return square;
        }

        static void display_result(string name, int square){
            Console.WriteLine($"{name}, the square of your number is: {square}");
        }
}