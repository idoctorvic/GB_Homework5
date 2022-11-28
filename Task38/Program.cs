// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = NewArray();
Print(array);
Console.Write($"The min is {Min(array)}. The max is {Max(array)}.");
Console.WriteLine();
Console.Write(Diff());

double[] NewArray()
{
    Console.Write("Enter the length of the list: ");
    int size = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble()*100, 2);
    }
    return array;
}

void Print(double[] array)
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

double Min(double[] array)
{
    double minNum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minNum)
        {
            minNum = array[i];
        }
    }
    return minNum;
}

double Max(double[] array)
{
    double maxNum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNum)
        {
            maxNum = array[i];
        }
    }
    return maxNum;
}

double Diff()
{
    double diff = Max(array) - Min(array);
    double result = Math.Round(diff, 2);
    return result;
}