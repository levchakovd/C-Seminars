Console.WriteLine("Введите количество грядок от 3 до 1000");
int n = Convert.ToInt32(Console.ReadLine());
int i=0;
if (n>=3 || n<=1000)
    Console.WriteLine("Сейчас посчитаем");
else 
{
    Console.WriteLine("Введите количество грядок от 3 до 1000");
}
int [] array = new int [n];
Console.WriteLine("Сейчаc выведем сколько ягод растет на грядках");
for (i = 0; i< n; i++)
    array[i] = new Random().Next(0,1000);

Console.WriteLine("["+ string.Join(", ", array)+ "]");

int mid = array[i];
int mid1=0;
int mid2=0;
int maxloc=0;
int maxloc1=0;
int maxloc2=0;

if (i<1)
    maxloc=


Console.WriteLine(maxloc);
