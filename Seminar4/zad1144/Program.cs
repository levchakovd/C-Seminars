int [] array = new int [100];
Console.WriteLine("Введите массив");

for (int i = 0; i<100 || array[i] !=0; i++)
{
    array[i]=Convert.ToInt32(Console.ReadLine());

}

// Ввод массива не обрывается после ввода 0
// Не получается ввести все элементы массива, выдает ошибку