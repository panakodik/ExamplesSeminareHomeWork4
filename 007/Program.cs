// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
Console.Clear();
Console.WriteLine();
int size = new Random().Next(1, 11);//определяем количество элементов массива
Console.WriteLine($"Количетсов элементов массива: {size}");
double[] AssignArray(int size)// метод заполнения элементов массива вещественными числами
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 10;
    }
    return array;
}
void DiffMinMax(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
    double difference = arr.Max() - arr.Min(); //  вычисление разницы максимального и минимального значения элемента массива
    Console.WriteLine($"Минимальное значение массива {arr.Min()}, максимальное значение массива {arr.Max()}");
    Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет {difference}");
    Console.WriteLine();
}
DiffMinMax(AssignArray(size));
Console.WriteLine();