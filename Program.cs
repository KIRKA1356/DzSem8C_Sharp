/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8

Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1)
Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/

/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8
*/

/*
Console.WriteLine("Введите значение строк");
int rows = Convert.ToInt32(Console.ReadLine());                     //Задача 54 !!(НЕ РЕШЕНА Проблема с первым элементом каждой строки)!!
Console.WriteLine("Введите значение столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива");
int max = Convert.ToInt32(Console.ReadLine());

int[,] CreateRandom2dArray(int rows, int columns, int min, int max)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    Console.WriteLine("Задан массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


int[,] Uporiadochit(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int temp = array[i, j];
            if (j==1)
            {
                j=0;
                if (array[i, j] > array[i, j + 1])
                {
                    array[i, j] = array[i, j + 1];
                    array[i, j + 1] = temp;
                    j=2;
                }
            }
            if (array[i, j] > array[i, j + 1])
            {
                array[i, j] = array[i, j + 1];
                array[i, j + 1] = temp;
            }
        }

    }
    return array;
}

int[,] MyArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(MyArray);
Show2dArray(Uporiadochit(MyArray));
*/
/*
Console.WriteLine("Введите значение строк");
int rows = Convert.ToInt32(Console.ReadLine());                     //Задача 56 (проблема с индексами)
Console.WriteLine("Введите значение столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива");
int max = Convert.ToInt32(Console.ReadLine());

int[,] CreateRandom2dArray(int rows, int columns, int min, int max)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    Console.WriteLine("Задан массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int NaimSum(int[,] array)
{
    int min = 1000;
    int min_indx = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            {
            sum = array[i, j] + sum;
            }
        if (min > sum)
        {
            min = sum;
            min_indx = i;
            sum = 0;
        }
    }
    return min_indx;
}

int[,] MyArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(MyArray);

Console.WriteLine("Индекс строки с наименьшой суммой элементов: " + NaimSum(MyArray));
*/

/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, заданы 2 массива:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
и
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
Их произведение будет равно следующему массиву:
1 20 56 10
20 81 8 6
56 8 4 24
10 6 24 49
*/

/*
Console.WriteLine("Введите значение строк 1 матрицы");
int rows = Convert.ToInt32(Console.ReadLine());                     //Задача 58 (решена)
Console.WriteLine("Введите значение столбцов 1 матрицы");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива 1 матрицы");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива 1 матрицы");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение строк 2 матрицы");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение столбцов 2 матрицы");
int columns2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива 2 матрицы");
int min2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива 2 матрицы");
int max2 = Convert.ToInt32(Console.ReadLine());

int[,] CreateRandom2dArray(int rows, int columns, int min, int max)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    Console.WriteLine("Задан массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] Proizved(int[,] array1, int[,] array2)
{
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(0); j++)
        {
            array1[i, j] = array1[i, j] * array2[i, j];
        }
    }
    return array1;
}

void ShowProizv(int[,] array)
{
    Console.WriteLine("Итоговое произведение матриц: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MyArray = CreateRandom2dArray(rows, columns, min, max);
int[,] MyArray2 = CreateRandom2dArray(rows2, columns2, min2, max2);
Show2dArray(MyArray);
Console.WriteLine("и");
Console.WriteLine();
Show2dArray(MyArray2);
ShowProizv(Proizved(MyArray, MyArray2));
*/

/*
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
массив размером 2 x 2 x 2
12(0,0,0) 22(0,0,1)
45(1,0,0) 53(1,0,1)
*/

Console.WriteLine("Введите значение строк");
int rows = Convert.ToInt32(Console.ReadLine());                     //Задача 60 
Console.WriteLine("Введите значение столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение высоты");
int H = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение массива");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение массива");
int max = Convert.ToInt32(Console.ReadLine());

int[,,] CreateRandom2dArray(int rows, int columns, int H,  int min, int max)
{
    int[,,] newArray = new int[rows, columns, h];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(min, max + 1);
        }
    }
    return newArray;
}

void Show2dArray(int[,] array)
{
    Console.WriteLine("Задан массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

/*
Задача 62. Заполните спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7
*/
