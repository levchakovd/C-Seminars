//Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//массив размером 2 x 2 x 2
//12(0,0,0) 22(0,0,1)
//45(1,0,0) 53(1,0,1)

int n = 2;
int l = 2;
int m = 2;
int[,,] array3d = new int[n, l, m];

for (int i = 0; i < n; i++)
{   
    for (int k = 0; i < l; i++)

        for (int j = 0; j < m; j++)
        {
            array3d[i,k, j] = new Random().Next(10, 100);
        }
}
for (int i = 0; i < n; i++)
{
    for (int k = 0; i < l; i++)
        for (int j = 0; j < m; j++)
            Console.Write(array3d[i,k,j]+"(" + i +","+ k +","+j+")" + " \t");
    Console.WriteLine();
}
