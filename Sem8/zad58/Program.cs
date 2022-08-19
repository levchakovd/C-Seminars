Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];

Console.WriteLine("первая матрица");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix[i, j] = new Random().Next(0, 10);
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
        Console.Write(matrix[i, j] + " \t");
    Console.WriteLine();
}
Console.WriteLine("вторая матрица");

int[,] matrix2 = new int[n, m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix2[i, j] = new Random().Next(0, 10);
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
        Console.Write(matrix2[i, j] + " \t");
    Console.WriteLine();
}

Console.WriteLine("Перемножим");

int[,] matrix3 = new int[n, m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix3[i, j] = matrix[i,j]*matrix2[i,j];
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
        Console.Write(matrix3[i, j] + " \t");
    Console.WriteLine();
}
