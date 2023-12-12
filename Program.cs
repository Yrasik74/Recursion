//Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

using System;

class AckermannFunction
{
static int Ack(int m, int n)
{
if (m == 0)
return n + 1;
else if (n == 0)
return Ack(m - 1, 1);
else
return Ack(m - 1, Ack(m, n - 1));
}

static void Main()
{
Console.WriteLine("Введите два неотрицательных целых числа m и n:");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());

int result = Ack(m, n);
Console.WriteLine($"Результат функции Аккермана для m = {m} и n = {n} равен {result}");
}
}