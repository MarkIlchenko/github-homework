using System;

class Program
{
    private const double V = 3.3;
    private static bool isMale = true;

    static void Main()
    {
        int myAge = 19;
        string myName = "Mark Ilchenko";
        double gpa = V;

        if (isMale)
        {
            Console.WriteLine($"Hello I'm {myName}, and I'm {myAge} years old! {gpa}");
            Console.WriteLine(myName.Substring(1, 5));
        } else
        {
            Console.WriteLine("Add isMale");
        }

        Console.ReadLine();
    }
}