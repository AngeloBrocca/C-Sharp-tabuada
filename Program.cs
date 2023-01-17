using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Insira numero para calculo");
        string n = Console.ReadLine();
        Console.WriteLine("______________________________________________");

        int x = Convert.ToInt32(n);

        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine(x+" X "+i+" = "+i*x);
        }

    }
}
