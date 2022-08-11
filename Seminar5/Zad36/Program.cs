Console.WriteLine("Введите размер массива");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i<array.Length;i++)
    array[i]=new Random().Next(0,100);

Console.WriteLine("["+ string.Join(",",array)+"]");

int summ = 0;
for (int i = 1; i< array.Length;i=i+2)

    summ = summ+array[i];

Console.WriteLine(summ);