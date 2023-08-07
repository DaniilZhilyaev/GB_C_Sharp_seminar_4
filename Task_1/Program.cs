// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// 7 -> 28

// 4 -> 10

// 8 -> 36

Console.Write("Enter number: ");
int A = int.Parse(Console.ReadLine()!);

int SummFrom1(int x)
{
    int result = 0;
    for (int i = 1; i <= x; i++)
    {
        result = result + i;
    }
    return result;
}
int B = SummFrom1(A);
Console.WriteLine($"Summ: {B}");