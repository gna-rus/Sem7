/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.Clear();

int[,] FillMatrix(int[,] matr) // метод заполнения и вывода на экран матрицы
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(0, 11);
            Console.Write($"{matr[i, j]} "); // вывод на экран результата генерации
        }
        Console.WriteLine();
    }
    return matr;
}
int[] SumMean(int[,] mtrx) // создается одномерный массив с суммой в каждом отдельном столбце
{
    int[] arr = new int[mtrx.GetLength(1)];
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            arr[j] += mtrx[i, j]; // создание одномерного массива с суммой значений в каждома столбце
        }
        Console.WriteLine();
    }
    return arr;
}

void OutputArray(int[] arr) // вывод на экран подсчета среднего значения
{
    double rez;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < arr.Length; i++)
    {
        rez = Math.Round(Convert.ToDouble(arr[i]) / 3, 1); // конвертация int в double и вывод результата деления с 1 знаком после запятой        
        Console.Write($"{rez}; ");
    }
    Console.WriteLine();
}
int[,] matrix = new int[3, 4];
int[] array = new int[4];
matrix = FillMatrix(matrix);
array = SumMean(matrix);
OutputArray(array);
