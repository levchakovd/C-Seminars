Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[n, m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
        matrix[i, j] = Convert.ToDouble(new Random().NextDouble()*10);
        
    
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
        Console.Write( Math.Round(matrix[i, j],1) + " \t");
    Console.WriteLine();
}
