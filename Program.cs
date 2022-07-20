/*
Console.WriteLine("Введите значение строк");
int rows = Convert.ToInt32(Console.ReadLine());                     //Задача 54
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
            int temp = 0;
            for (int m = 0; m < array.GetLength(1) - 1; m++)
            {
                if (array[i, m] > array[i, m + 1])
                {
                    temp = array[i,m];
                    array[i, m] = array[i, m + 1];
                    array[i, m + 1] = temp;
                }
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
int rows = Convert.ToInt32(Console.ReadLine());                     //Задача 56
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
    return min_indx + 1;
}

int[,] MyArray = CreateRandom2dArray(rows, columns, min, max);
Show2dArray(MyArray);

Console.WriteLine(NaimSum(MyArray) + " строка");
*/



/*
Console.WriteLine("Введите значение строк 1 матрицы");
int rows = Convert.ToInt32(Console.ReadLine());                     //Задача 58 
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
int[,,] CreateRandom2dArray(int x, int y, int z, int min, int max)
{
    int[,,] newArray = new int[x, y, z];                                                    //Задача 60

    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            for (int k = 0; k < newArray.GetLength(2); k++)
            {
                newArray[i, j, k] = new Random().Next(1, 100);
            }
            
        }
    }
    return newArray;
    
}

void Show2dArray(int[,,] array)
{
    Console.WriteLine("Задан массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write(array [i, j, k] + "(" + i + "," + j + "," + k + ") ");
            }

            Console.WriteLine();
        }
    }
    Console.WriteLine();
}
int[,,] MyArray = CreateRandom2dArray(3,3,3,1,99);
Show2dArray(MyArray);
*/




/*
int[,] CreateSpirArray()
{
    int i = 0, n = 4, l = 0, j = 0;
    int[,] modarray = new int[n, n];                    //Задача 62
    for (i = 0; i < n; i++)
    {
        modarray[j, i] = l;
        l++;
    }
    for (i = 1; i < n; i++)
    {
        modarray[i, n - 1] = l;
        l++;
    }
    for (i = n - 2; i >= 0; i--)
    {
        modarray[n - 1, i] = l;
        l++;
    }
    for (i = n - 2; i > 0; i--)
    {
        modarray[i, n - 4] = l;
        l++;
    }
    for (i = n - 3; i < 3; i++)
    {
        modarray[n - 3, i] = l;
        l++;
    }
    for (i = n - 2; i > 0; i--)
    {
        modarray[n - 2, i] = l;
        l++;
    }
    return modarray;
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

int[,] MyArray = CreateSpirArray();
Show2dArray(MyArray);
*/
