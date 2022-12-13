// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

int rows = 5;
int columns = 5;

int enterMandN(string massage)
{
    System.Console.Write(massage);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int[,] createRandomArrey(int rows, int columns, int leftRange, int rightRange)
{
    int[,] arrey = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arrey[i, j] = new Random().Next(leftRange + rightRange);
        }
    }
    return arrey;
}

void showArrey(int[,] arrey)
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            System.Console.Write(arrey[i, j] + " ");
        }
        System.Console.WriteLine();
    }
    int compare = enterMandN("enter number: ");
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            if (arrey[i, j] == compare)
            {
                System.Console.WriteLine(compare + " -> This number is present here under the index [" + (i , j) + "]");
            
            }
        }
    }
}

int[,] matricx = createRandomArrey(rows, columns, 0, 10);
showArrey(matricx);

