int [] array = new int [8];
Console.WriteLine("Сейчас Вы введете 8 чисел, а я покажу их массивом");
for (int i = 0; i< 8; i++)
{
    Console.WriteLine("Введите число с индексом "+ i);
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("["+ string.Join(", ", array)+ "]");