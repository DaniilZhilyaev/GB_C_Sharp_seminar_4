/*Задача 1: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

4 -> 24
5 -> 120*/

Console.Write("Enter number: ");
int N = int.Parse(Console.ReadLine()!);

int DefFrom1(int x)
{
    int result = 1;
    for (int i = 1; i <= x; i++)
    {
        result = result * i;
    }
    return result;
}

Console.WriteLine($"Definition from 1 to {N} is {DefFrom1(N)}");