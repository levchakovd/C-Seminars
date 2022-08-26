Console.Write("Введите первое число ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.Write("Введите второе число ");
int m = Convert.ToInt32(Console.ReadLine());

if (n>m)
{
    int temp = 0;
    temp = n;
    n = m;
    m = temp;

}

int summ = 0;

while (n<=m)
{
    summ += n;
    n++ ;
}

Console.WriteLine(summ);