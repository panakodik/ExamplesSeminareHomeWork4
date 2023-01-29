// Задать массив из 8 элементов, заполненных нулями и единицами. вывести их на экран
int[] array = new int[8]; //Задаем масиив
int length = array.Length;
/*
int index = 0;
while (index < length)
{
    array[index] = new Random().Next(0, 2);
    index++;
}                          // задаем массив
*/
for (int i = 0; i < length; i++) // Так мне нравится больше!
{
    array[i] = new Random().Next(0, 2);
}
Console.WriteLine("{0}", string.Join("; ", array)); //Вывод заданного массива