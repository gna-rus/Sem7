/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет. 
Например, задан массив:
1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет*/


Console.Clear();

int[,] FillMatrix(int[,] matr) // метод заполнения и вывода на экран матрицы
{
    Random rnd = new Random();
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rnd.Next(-10, 11);
            Console.Write($"{matr[i, j]} "); // вывод на экран результата генерации
        }
        Console.WriteLine();
    }
    return matr;
}

int InputNumber() // ввод позиции элемента
{
    int num;
    while (true)
    {
        Console.WriteLine("Введите число");
        if (int.TryParse(Console.ReadLine(), out num))
            break;
        Console.WriteLine("Ошибка ввода");
    }
    return num;
}

void PrintMatrix(int[,] matr, int nums) // поиск элемента значения по номеру и вывод на экран результата поиска
{
    int count = 0;
    bool flag = false;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            count++;
            if (count == nums)
            {
                Console.WriteLine($"На позиции {count} -> {matr[i, j]}");
                flag = true;
            }
        }
        Console.WriteLine();
    }
    if (flag == false) Console.WriteLine("такого числа в массиве нет");
}

int num = InputNumber(); // метод ввода номера индекса
int[,] matrix = new int[3, 4];
matrix = FillMatrix(matrix); // обращение к методу генерирующий матрицу и выводящий ее на консоль
PrintMatrix(matrix, num); // поиск элемента в матрице
