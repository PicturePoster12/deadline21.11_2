using System;
class Program
{
    static int Massiv(ref double proizv, out double average, params int[] arr)
    {
        int sum = 0;
        proizv = 1;
        average = 0;
        foreach (int i in arr)
        {
            sum += i;
            proizv *= i;
        }
        average = (double)sum / arr.Length;
        return sum;
    }
    public struct Ded()
    {
        public string name;
        public LevelOfGrumping grumping;
        public string[] phrases = [];
        public int fingals = 0;
        public int Fingals(Ded ded, params string[] cenzoured) 
        {
            foreach (string s in cenzoured) { 
                if (ded.phrases.Contains(s))
                {
                    ded.fingals++;
                }
            }
            return ded.fingals;
        }
    }
    public enum LevelOfGrumping
    {
        Easy,
        Normal,
        Hard,
    }
    static void Main()
    {
        Task1();
        Task2();
        Task3();
        Task4();
    }
    static void Task1()
    {
        Console.WriteLine("1.");
        Random random = new Random();
        int[] massiv = new int[20];
        for (int i = 0; i < 20; i++)
        {
            massiv[i] = random.Next(100);
            Console.Write($"{massiv[i]} ");
        }
        try
        {
            Console.WriteLine();
            Console.WriteLine("Введите 2 числа из списка выше:");
            int pervoe = Convert.ToInt32(Console.ReadLine());
            int vtoroe = Convert.ToInt32(Console.ReadLine());
            if (massiv.Contains(pervoe) & massiv.Contains(vtoroe))
            {
                int index1 = Array.IndexOf(massiv, pervoe);
                int index2 = Array.IndexOf(massiv, vtoroe);
                int temp = massiv[index1];
                massiv[index1] = massiv[index2];
                massiv[index2] = temp;
                foreach (int i in massiv)
                {
                    Console.Write($"{i} ");
                }
                Console.WriteLine();
            }
            else
            {
                throw new FormatException();
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
    }
    static void Task2()
    {
        Console.WriteLine("2.");
        Console.WriteLine("Введите 5 чисел:");
        int[] array = new int[5];
        try
        {
            double average;
            double proizv = 1;
            for (int i = 0; i < 5; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = Massiv(ref proizv, out average, array);
            Console.WriteLine($"Сумма = {sum}");
            Console.WriteLine($"Произведение = {proizv}");
            Console.WriteLine($"Среднее арифмитическое = {average}");
        }
        catch
        {
            Console.WriteLine("Неверный ввод");
        }
    }
    static void Task3()
    {
        Console.WriteLine("3.");
        try
        {
            int a = 1;
            while (a != 0)
            {
                Console.WriteLine("Напишите 'exit' или 'закрыть', если хотите закрыть консоль");
                Console.WriteLine("Введите число от 0 до 9:");
                string digit_str = Console.ReadLine();
                if (digit_str == "exit" | digit_str == "закрыть")
                {
                    break;
                }
                int digit = int.Parse(digit_str);
                switch (digit)
                {
                    case 0: Console.WriteLine("#####"); Console.WriteLine("#   #"); Console.WriteLine("#   #"); Console.WriteLine("#   #"); Console.WriteLine("#####"); break;
                    case 1: Console.WriteLine("    #"); Console.WriteLine("  # #"); Console.WriteLine("#   #"); Console.WriteLine("    #"); Console.WriteLine("    #"); break;
                    case 2: Console.WriteLine("#####"); Console.WriteLine("    #"); Console.WriteLine("#####"); Console.WriteLine("#    "); Console.WriteLine("#####"); break;
                    case 3: Console.WriteLine("#####"); Console.WriteLine("    #"); Console.WriteLine("  ###"); Console.WriteLine("    #"); Console.WriteLine("#####"); break;
                    case 4: Console.WriteLine("#   #"); Console.WriteLine("#   #"); Console.WriteLine("#####"); Console.WriteLine("    #"); Console.WriteLine("    #"); break;
                    case 5: Console.WriteLine("#####"); Console.WriteLine("#    "); Console.WriteLine("#####"); Console.WriteLine("    #"); Console.WriteLine("#####"); break;
                    case 6: Console.WriteLine("#####"); Console.WriteLine("#    "); Console.WriteLine("#####"); Console.WriteLine("#   #"); Console.WriteLine("#####"); break;
                    case 7: Console.WriteLine("#####"); Console.WriteLine("#   #"); Console.WriteLine("    #"); Console.WriteLine("    #"); Console.WriteLine("    #"); break;
                    case 8: Console.WriteLine("#####"); Console.WriteLine("#   #"); Console.WriteLine("#####"); Console.WriteLine("#   #"); Console.WriteLine("#####"); break;
                    case 9: Console.WriteLine("#####"); Console.WriteLine("#   #"); Console.WriteLine("#####"); Console.WriteLine("    #"); Console.WriteLine("#####"); break;
                    default: Console.ForegroundColor = ConsoleColor.Red; Console.WriteLine("Ошибка"); Task.Delay(3000).Wait(); Console.ResetColor(); break;
                }
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Неверный ввод");
        }
    }
    static void Task4()
    {
        Console.WriteLine("4.");
        Ded Maksim = new Ded()
        {
            name = "Максим",
            grumping = LevelOfGrumping.Easy,
            phrases = ["Проститутки!", "Ироды!"]
        };
        Ded Semen = new Ded()
        {
            name = "Семён",
            grumping = LevelOfGrumping.Normal,
            phrases = ["Гады!", "Ироды!", "Твари!"]
        };
        Ded Aleksey = new Ded()
        {
            name = "Алексей",
            grumping = LevelOfGrumping.Hard,
            phrases = ["Проститутки!", "Гады!", "Ироды!", "С*ки!", "Сволочи!", "Бл*дь"]
        };
        Ded Grigory = new Ded()
        {
            name = "Григорий",
            grumping = LevelOfGrumping.Normal,
            phrases = ["Проститутки!", "Гады!", "Мрази!"]
        };
        Ded Victor = new Ded()
        {
            name = "Виктор",
            grumping = LevelOfGrumping.Easy,
            phrases = ["Уроды!"]
        };
        string[] mat = { "С*ки!", "Пид*расы!", "Г*ндоны!", "Бл*дь" };
        Ded ded = new Ded();
        Console.WriteLine(ded.Fingals(Aleksey, mat));
    }
}