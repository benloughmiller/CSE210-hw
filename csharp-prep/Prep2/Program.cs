using System;

class Program
{
    static void Main(string[] args)
    {   
        string letter_grade = "";
        Console.Write("What grade did you get?");
        int grade = int.Parse(Console.ReadLine());

        if (grade >= 90) {
            letter_grade = "A";
        }
        else if (grade < 90 && grade >= 80) {
            letter_grade = "B";
        }
        else if (grade < 80 && grade >= 70) {
            letter_grade = "C";
        }
        else if (grade < 70 && grade >= 60) {
            letter_grade = "D";
        }
        else {
            letter_grade = "F";
        }
        Console.WriteLine($"Your letter_grade is: {letter_grade}");

        if (grade >= 70) {
            Console.WriteLine("You passed the class.");
        }
        else {
            Console.WriteLine("You failed the class.");
        }
    }
}