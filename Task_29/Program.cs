/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (можно указать любой промежуток)
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

int[] array = GetRange(8);
Console.WriteLine($"[{String.Join(", ", array)}]");

//method
int[] GetRange(int size)
{
    int[] massive = new int[size];
    for (int i = 0; i < massive.Length; i++)
    {
        massive[i] = new Random().Next(999);
    }
    return massive;
}