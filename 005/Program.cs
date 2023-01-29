// Найти сумму чисел одномерного массива стоящих на нечетной позиции
Console.Clear();
int[] array = new int[10];
int length = array.Length;
int sum1 = 0;
Console.WriteLine("Дан массив");
for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(1, 11);
    if(i % 2 == 0)
    {
      }
    else
    {
        sum1 = sum1 + array[i-1];
    }
}
Console.WriteLine("{0}", string.Join("; ", array));
Console.WriteLine("Сумма чисел одномерного массива стоящих на нечетной позиции = " + sum1);