//Задача 1: Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.

using System;

class Program
{
static void Main()
{
int m = 1; // Значение M
int n = 10; // Значение N
PrintNaturalNumbers(m, n);
}

static void PrintNaturalNumbers(int m, int n)
{
if (m <= n)
{
Console.WriteLine(m);
PrintNaturalNumbers(m + 1, n);
}
}
}
