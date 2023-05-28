// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FillMatrixWhithRandomNumbers(int[,] matrix)
{
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 11);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} " + "\t");
        }
        System.Console.WriteLine();
    }
}

void FindElement(int[,] matrix, int x, int y)
{
   if( x < matrix.GetLength(0) && y < matrix.GetLength(1))
   System.Console.WriteLine($"Значение элемента массива: {matrix[x,y]}");
   else System.Console.WriteLine("такого элемента нет");
}

void FindIndex(int[,] matrix, int num)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(num == matrix[i,j])
            {
                System.Console.WriteLine($"Индекс элемента массива: {i} {j}");
            }
        }
    }
}

System.Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];

FillMatrixWhithRandomNumbers(matrix);
PrintMatrix(matrix);

System.Console.Write("Введите 1 - если ищете элемент по индексу, 2 - если ищете индекс элемента массива: ");
int variant = Convert.ToInt32(Console.ReadLine());

switch (variant)
{
    case 1:
    {
        System.Console.WriteLine("Введите строку элемента: ");
        int row = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Введите столбец элемента: ");
        int col = Convert.ToInt32(Console.ReadLine());
        FindElement(matrix, row, col);
        break;
    }
    case 2:
    {
        System.Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        FindIndex(matrix, number);
        break;
    }
    default:
    {
        System.Console.WriteLine("Такого варианта нет");
        break;
    }

}





