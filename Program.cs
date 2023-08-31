//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
void OutputNumbers(int m, int n)
{
    if (m <= n)
    {
        OutputNumbers(m + 1, n);
        Console.Write($"{m} ");
    }
}

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 1;
OutputNumbers(m, n);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M…
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
// Метод рекурсивно считает сумму натуральных чисел от par1 до par2
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Метод рекурсивно считает сумму натуральных чисел от par1 до par2
int SummNaturalsMtoN(int par1, int par2)
{
    if (par1 > par2) return 0;
    return SummNaturalsMtoN(par1, par2 - 1) + par2;
}

Console.Write("Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (numM >= numN)
{
    Console.WriteLine($"Сумма натуральных чисел от {numN} до {numM} равна {SummNaturalsMtoN(numN, numM)}.");
}
else
{
    Console.WriteLine($"Сумма натуральных чисел от {numM} до {numN} равна {SummNaturalsMtoN(numM, numN)}.");
}

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// Метод возвращает значение функции Аккермана
int AkkermanFunc(int m, int n)
{
    if (m < 0 || n < 0)
        return 0;
    if (m == 0)
        return n + 1;
    if (n == 0)
        return AkkermanFunc(m - 1, 1);
    return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
}

Console.Write("Введите число M: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.Write("Введите число N: ");
int numN = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine($"Значение ф.Аккермана = {AkkermanFunc(numM, numN)}");