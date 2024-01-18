using System;

class Program
{
    static void Main(string[] args)
    {
        int guess = 0;
        Random random_number = new Random();
        int magic_number = random_number.Next(1, 100);

        while (guess != magic_number) {
            Console.WriteLine("Please guess a number");
            guess = int.Parse(Console.ReadLine());

            if (guess > magic_number){
                Console.WriteLine("Your guess is too high.");
            }
            else if (guess < magic_number){
                Console.WriteLine("Your guess is too Low.");
            }
            else {
                Console.WriteLine("You got it!");
            }
            
        } 
        
    }
}