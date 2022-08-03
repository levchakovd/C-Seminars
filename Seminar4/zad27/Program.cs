int n = Convert.ToInt32(Console.ReadLine());
int summ = 0;

while (n>0)

{
    summ=summ+n%10;
    n=n/10;
}

Console.WriteLine(summ);


