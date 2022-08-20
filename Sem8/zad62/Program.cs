// Задача 62. Заполните спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//1 2 3 4
//12 13 14 5
//11 16 15 6
//10 9 8 7

Console.Write("Введите количество строк и столбиков ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= n * n)
{
  array[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < n - 1)
    j++;
  else if (i < j && i + j >= n - 1)
    i++;
  else if (i >= j && i + j > n - 1)
    j--;
  else
    i--;
}

for (int k = 0; k < n; k++)
{
    for (int h = 0; h < n; h++)
        Console.Write(array[k, h] + " \t");
    Console.WriteLine();
}
