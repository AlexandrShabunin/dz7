// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// первая цифра - номер строки, вторая - столбца. Цифры будем брать - не больше 9.
// Поскольку нужна позиция в массиве, то это есть ИНДЕКС. (будет вводить индекс).


// 44-> сообщает что такого числа в массиве нет

int rows = ReadInt("Введите индекс строки: ");
int colums = ReadInt("Введите индекс столбца: ");
int[,] numbers = new int[3, 4]; // 3 строки, 4 столбца
FillArray(numbers);
PrintArray(numbers);

if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1))
Console.WriteLine(numbers[rows, colums]);

else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");


// заполним массив рандомными числами от 1 до 9
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

//  реализуем Функцию вывода массива в терминал
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// ну и Функция ввода (обращаем внимание на строки 9,10)!!
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}