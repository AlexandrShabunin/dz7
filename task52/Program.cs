// Задайте двумерный массив из целых чисел. Найдите 
// среднее арифметическое элементов в каждом столбце.

Random random = new Random();
int[,] array = new int[random.Next(1, 5), random.Next(1, 5)];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(1, 5);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine(array.GetLength(0));
for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.Write($"{ sum / array.GetLength(0)} ");
}
Console.ReadLine();