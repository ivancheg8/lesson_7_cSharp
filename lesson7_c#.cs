//общий блок 

double[,] createRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

void show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

/* 
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
double[,] createRandom2dArrayDouble(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
    return newArray;
}
/* 
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] myArray = createRandom2dArrayDouble(m, n, 1, 9);
show2dArray(myArray);
*/




/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такого числа в массиве нет
*/
double FindNumber(double[,] array, int row, int column)
{
    if (row > array.GetLength(0) || column > array.GetLength(1))
    {
        Console.WriteLine("такого числа в массиве нет");
        return -1;
    }
    return array[row - 1, column - 1];
}
/*
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] myArray = createRandom2dArray(m, n, 1, 9);
show2dArray(myArray);

Console.Write("Введите строку: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите столбец: ");
int d = Convert.ToInt32(Console.ReadLine());
Console.Write(FindNumber(myArray, c, d));
*/





/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

void AverageInColumns(double[,] array)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        double s = sum / (array.GetLength(0));
        Console.Write(s + "; ");
    }
    return;
}

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] myArray = createRandom2dArray(m, n, 1, 9);
show2dArray(myArray);
Console.WriteLine();
AverageInColumns(myArray);
