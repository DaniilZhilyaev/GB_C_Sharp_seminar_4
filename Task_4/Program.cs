// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

// int massive8()
// {
//     int[] result = {0, 0, 0, 0, 0, 0, 0, 0};
//     for (int i = 0; i <= 7; i++)
//     {
//         result[i] = new Random().Next(0, 1);
//     }
//     return result;
// }



// int[] array = massive8();

// Console.WriteLine(array);
// Задача 3: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

int[] array = GetRange(8);
Console.WriteLine($"[{String.Join(", ", array)}]");

//method
int[] GetRange(int size)
{
    int[] massive = new int[size];
    for (int i = 0; i < massive.Length; i++)
    {
        massive[i] = new Random().Next(2);
    }
    return massive;
}