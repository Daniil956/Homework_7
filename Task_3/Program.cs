// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int[,] EnterMassif(int rows, int columns, int leftRange, int rightRange)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(leftRange + rightRange);
        }
    }
    return array;
}

void ShowArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int[,] matrix = EnterMassif (3, 5, 0, 10);
ShowArray (matrix);

double sum = 0;
for (int i = 0; i < matrix.GetLength(1); i++)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        sum += matrix[j, i];
    }
    double result = sum / matrix.GetLength(0);
    System.Console.Write(Math.Round(result, 2) + " | ");
}



// for (int i = 0; i < arrey.GetLength(1); i++)
// {
//     Console.Write((sum / arrey.GetLength(0)) + " ");
// }
// Console.ReadLine();










//  int[] sum = new int[arrey.GetLength(0)];

//     for (int i = 0; i < arrey.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrey.GetLength(1); j++)
//         {   
//             sum[i] = 0;
//             double divider = 0;
//             sum[i] += arrey[i,j];
//             System.Console.Write(" |Сумма " + i.ToString() + " столбца = " + sum[i].ToString());
//             break;
//         }
//     }
// }