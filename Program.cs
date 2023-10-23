// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
/*
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        if (N < 1)
        {
            Console.WriteLine("N должно быть натуральным числом.");
            return;
        }

        PrintNaturalNumbers(N);
    }

    static void PrintNaturalNumbers(int n)
    {
        if (n >= 1)
        {
            Console.Write($"{n} ");
            PrintNaturalNumbers(n - 1);
        }
    }
}
*/
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение M: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        if (M < 1 || N < 1)
        {
            Console.WriteLine("M и N должны быть натуральными числами.");
        }
        else
        {
            int sum = CalculateSum(M, N);
            Console.WriteLine($"Сумма натуральных чисел в промежутке от {M} до {N} равна: {sum}");
        }
    }

    static int CalculateSum(int m, int n)
    {
        if (m == n)
            return m;
        if (m < n)
            return m + CalculateSum(m + 1, n);
        return 0; // Если M больше N или заданы некорректные значения.
    }
}
*/
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
// m = 3, n = 2 -> A(m,n) = 9
/*
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение n: ");
        int n = int.Parse(Console.ReadLine());

        int result = Ackermann(m, n);

        Console.WriteLine($"A({m},{n}) = {result}");
    }

    static int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        if (m > 0 && n == 0)
            return Ackermann(m - 1, 1);
        if (m > 0 && n > 0)
            return Ackermann(m - 1, Ackermann(m, n - 1));
        return 0; // В случае некорректных входных данных.
    }
}
*/
