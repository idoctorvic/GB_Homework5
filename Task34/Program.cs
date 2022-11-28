// Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

var array = NewArray(100, 1000);
Print(array);
Console.WriteLine($"The amount of even numbers is {CountEven(array)}.");

int[] NewArray(int min, int max)
{
    Console.Write("Enter the length of the list: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max);
    }
    return array;
}



void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.WriteLine($"{array[i]}");
        }
        else
        {
            Console.Write($"{array[i]}, ");
        }
    }
}

int CountEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}