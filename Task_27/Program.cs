/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

Console.Write("Enter A: ");
int A = int.Parse(Console.ReadLine()!);

int summNum(int x)
{
    int result = 0;
    string xstr = x.ToString();
    for (int i = 0; i < xstr.Length; i++)
    {
        result = result +  int.Parse(xstr[i].ToString());
    }
    return result;   
}

Console.WriteLine($"Summ of numbers {A} = {summNum(A)}");