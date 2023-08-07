/*Задача 2: Определить, является ли заданное шестизначное число счастливым.
(Счастливым называют такое шестизначное число, что сумма его первых трех цифр равна сумме его
последних трех цифр, порядок чисел в сумме не важен). Решить самым оптимальным способом*/

Console.Write("Enter 6-size number: ");
int n = int.Parse(Console.ReadLine()!);

HappyNumber(n);

void HappyNumber(int x)
{
    string xstr = x.ToString();
    if (xstr.Length == 6)
    {
        if (xstr[0] + xstr[1] + xstr[2] == xstr[3] + xstr[4] + xstr[5])
        {
            Console.WriteLine($"Number {n} is Happy =)");
        }
        else Console.WriteLine($"Number {n} not Happy =(");

    }
    else Console.WriteLine($"Number {n} not 6-size");
}

