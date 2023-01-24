/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9*/
Console.Clear();

void PrintMatrix(double[,] matr) // метод заполнения и вывода на экран матрицы
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = Math.Round(rnd.NextDouble()*rnd.Next(-10,11),1); // генерирую случайное десятичную дробь от -10 до 10 с 1 символом после запятой 	
            Console.Write($"{matr[i, j]} "); // вывод на экран результата генерации
        }
        Console.WriteLine();
    }
}

double[,] matrix = new double[3, 4];
PrintMatrix(matrix); // обращение к методу генерирующий матрицу

