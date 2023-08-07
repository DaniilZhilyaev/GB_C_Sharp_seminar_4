/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

Console.Write("Enter A: ");
int A = int.Parse(Console.ReadLine()!);

Console.Write("Enter B: ");
int B = int.Parse(Console.ReadLine()!);

int square(int n, int k)
{
    int result = 1;
    for (int i = 1; i <= k; i++)
    {
        result = result * n;
    }
    return result;
}

Console.WriteLine($"{A} square {B} = {square(A, B)} ");
