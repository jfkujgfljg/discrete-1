using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsPerfectNumber(number))
        {
            Console.WriteLine($"{number} It's a perfect number.");
        }
        else
        {
            Console.WriteLine($"{number} Not a perfect number. ");
        }
    }

    static bool IsPerfectNumber(int num)
    {
        int sum = 0;

        for (int i = 1; i < num; i++)
        {
            if (num % i == 0)
            {
                sum += i;
            }
        }

        return sum == num;
    }
}