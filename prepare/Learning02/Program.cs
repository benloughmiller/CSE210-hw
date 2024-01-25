using System;

class Program
{
    static void Main(string[] args)
    {   

        Job job1 = new Job();
        job1._role = "IT Specialist";
        job1._company = "Job Inc";
        job1._start = 2022;
        job1._end = 2023;

        Job job2 = new Job();
        job2._role = "CEO";
        job2._company = "Salesforce";
        job2._start = 2020;
        job2._end = 2022;

        Resume make_resume = new Resume();
        make_resume._name = "Steven Stevenson";

        make_resume._jobs.Add(job1);
        make_resume._jobs.Add(job2);

        make_resume.Display();
    }
}