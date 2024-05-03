
Console.Write("Задайте количество строк двумерного массива: ");
int rowCount = Convert.ToInt32(Console.ReadLine());

Console.Write("Задайте количество столбцов двумерного массива: ");
int columnCount = Convert.ToInt32(Console.ReadLine());


char[,] matrix = new char[rowCount, columnCount];


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"Задайте элемент [{i}, {j}] символьного массива: ");
        matrix[i, j] = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("");
    }
}

string result ="";
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        result = result + matrix[i, j];

    }
}

Console.WriteLine (result);