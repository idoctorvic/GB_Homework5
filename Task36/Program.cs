// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

var array = NewArray(- 100, 100);
Print(array);
Console.Write($"The summ is {SumOddIndex(array)}.");

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

int SumOddIndex(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum += array[i];
    }
    return sum;
}
