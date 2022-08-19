Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];

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

Console.WriteLine("Выведем сумму элементов строк : ");

int[] min = new int[n];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        min[i] += matrix[i,j];
    }
}
int k = 0;
for (int j = 0; j < n; j++)
{
    if (min[j]<min[k])  
        k=j; 
        
}

for (int j = 0; j < n; j++)
        Console.Write(min[j] + " \t");
    Console.WriteLine();

Console.WriteLine("Индекс строки с минимальной суммой элементов = " +k);




