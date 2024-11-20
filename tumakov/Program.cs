using System;
class Laba
{
    static int Maximum(int a, int b)
    {
        return Math.Max(a, b);
    }
     static void Replace(ref string a, ref string b)
    {
        string c = a; a = b; b = c;
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
    static (int, bool) Factorial(int a)
    {
        int res = 1;
        try
        {
            checked
            {
                for (int i = 1; i <= a; i++)
                {
                    res *= i;
                }
            }
            return (res, true);
        }
        catch (OverflowException)
        {
            return (res, false);
        }
    }
    static int RecursionFactorial(int a)
    {
        if (a == 0)
        {
            return 1;
        }
        return a * RecursionFactorial(a - 1);
    }
    static int NOD(int m, int n)
    {
        if (m != n)
        {
            while (m != n)
            {
                if (m > n)
                {
                    m -= n;
                }
                else
                {
                    n -= m;
                }
            }
            return n;
        }
        else
        {
            return n;
        }
    }
    static int NOD(int m, int n, int p)
    {
        if (m != n | m != p)
        {
            while (m != n)
            {
                if (m > n)
                {
                    m -= n;
                }
                else
                {
                    n -= m;
                }
            }
            while (m != p)
            {
                if (m > p)
                {
                    m -= p;
                }
                else
                {
                    p -= m;
                }
            }
            return p;
        }
        else
        {
            return n;
        }
    }
    static int Fibonachi(int k)
    {
        if (k == 1)
        {
            return 1;
        }
        else if (k == 2)
        {
            return 1;
        }
        return Fibonachi(k - 1) + Fibonachi(k - 2);
    } 
    static void Main()
    {
        try
        {
            Console.WriteLine("5.1");
            Console.WriteLine("Введите 2 целых числа:");
            int pervoe = Convert.ToInt32(Console.ReadLine());
            int vtoroe = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Максимальное = {Maximum(pervoe, vtoroe)}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }

        Console.WriteLine("5.2");
        var param1 = Console.ReadLine();
        var param2 = Console.ReadLine();
        Replace(ref param1, ref param2);

        Console.WriteLine("5.3");
        Console.WriteLine("Введите число:");
        try {
            int chislo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Factorial(chislo));
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }

        Console.WriteLine("5.4");
        Console.WriteLine("Введите число:");
        try
        {
            int chislo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(RecursionFactorial(chislo));
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }

        Console.WriteLine("dz5.1");
        try
        {
            Console.WriteLine("Введите 2 натуральных числа:");
            int first = Convert.ToInt32(Console.ReadLine());
            int second = Convert.ToInt32(Console.ReadLine());
            if (first == 0 | second == 0)
            {
                throw new FormatException();
            }
            else
            {
                Console.WriteLine("НОД = " + NOD(first, second));
            }
            Console.WriteLine("Введите третье натуральное число:");
            int third = Convert.ToInt32(Console.ReadLine());
            if (third == 0)
            {
                throw new FormatException();
            }
            else
            {
                Console.WriteLine("Теперь НОД = " + NOD(first, second, third));
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }

        Console.WriteLine("dz5.2");
        Console.WriteLine("Введите натуральное число:");
        try
        {
            int k = Convert.ToInt32(Console.ReadLine());
            if (k < 1)
            {
                throw new FormatException();
            }
            else
            {
                Console.WriteLine(Fibonachi(k));
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
    }
}