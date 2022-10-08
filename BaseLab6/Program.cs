using System;
using System.Numerics;

class Program
{
    public static int Main()
    {
        while (true)
        {
            Console.Write("Введите число : ");
            int num = int.Parse(Console.ReadLine());
            BigInteger result = Factorial(num);
            Console.WriteLine(result);
            result = FactorialByRec(num);
            Console.WriteLine(result);
        }
    }

    private static BigInteger FactorialByRec(int num)
    {
        BigInteger fact = BigInteger.One;
        if (num == 0) return 1;
        return num * FactorialByRec(num - 1);
    }

    static BigInteger Factorial(int x)
    {
        BigInteger factorial = 1;
        for (int i = 1; i <= x; i++)
        {
            factorial *= i;
        }
        return factorial;
    }
}

