// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] matrix = new int[3, 4];
FillArray(matrix);
Console.WriteLine("Задан массив:");
PrintMatrix(matrix);
Console.WriteLine("Введите номер строки");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца");
int column = Convert.ToInt32(Console.ReadLine());

void FillArray(int[,] matr)                      // Заполнение матрицы рандомными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintMatrix(int[,] matr)              // Печать матрицы
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

if (row > matrix.GetLength(0) || column > matrix.GetLength(1))
{
    Console.WriteLine("Такого числа в массиве нет");
}
else
{
    Console.WriteLine($"Искомый элемент равен {matrix[row - 1, column - 1]}");
}












// FillArray(matrix);
// PrintMatrix(matrix);
// Console.WriteLine("Введите номер строки");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер столбца");
// int column = Convert.ToInt32(Console.ReadLine());