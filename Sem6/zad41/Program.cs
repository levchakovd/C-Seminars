Console.WriteLine("Сколько чисел М, Вы введете?");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine("Введите число с индексом "+i);
    array[i] = Convert.ToInt32(Console.ReadLine());
}
int count= 0;
for (int i = 0; i < array.Length; i++)
if (array[i]>0)
    count++;

Console.WriteLine("Положительных чисел "+ count);
