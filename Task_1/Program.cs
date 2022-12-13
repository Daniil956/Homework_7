// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

int enterMandN(string massage)
{
    System.Console.Write(massage);
    int number = int.Parse(Console.ReadLine());
    return number;
}

double[,] createRandomArrey(int rows, int columns, int leftRange, int rightRange)
{
    double[,] arrey = new double[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            arrey[i, j] = new Random().NextDouble()*(leftRange + rightRange);
        }
    }
    return arrey;
}

void showArrey (double [,] arrey)
{
    for(int i = 0; i < arrey.GetLength(0); i++)
    {
        for(int j = 0; j < arrey.GetLength(1); j++)
        {
            System.Console.Write( Math.Round(Convert.ToDouble(arrey[i, j]), 2) + " ");
        }
        System.Console.WriteLine();
    }
}

int m = enterMandN("Enter m: ");
int n = enterMandN("Enter n: ");
double[,] matricx = createRandomArrey(m, n, 0, 10);
showArrey(matricx);

