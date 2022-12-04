using System;
class Program
{
    // This line is return in the experiment branch 
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        if (n % 2 == 0)
        {
            Console.WriteLine("Even number");
        }
        else
        {
            Console.WriteLine("Odd number");
        }
    }

}
