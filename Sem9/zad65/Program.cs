//Задача 65: Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5 -> "1, 2, 3, 4, 5"
//M = 4; N = 8 -> "4, 6, 7, 8"

string f(int n)
{
    int i = 0;
    int summ = 0;
    while (i < n)
        {
            summ = summ +Convert.ToInt32(n[i]);
            i++;
        }
    Console.WriteLine(summ);

}


int n = Convert.ToInt32(Console.ReadLine());


Console.WriteLine(f(n));
