// Задача 1

/*
int[,] CreateRandomTwoDemArray(int a, int b, int min, int max)
{
    int[,] newMatrix = new int[a,b];
    for(int i = 0; i < a; i++)
    {
        for(int j = 0; j < b; j++)
        {
            newMatrix[i,j] = new Random().Next(min, max + 1);
        }
    }
    
    return newMatrix;
}

void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [,] BubleSorting(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int z = 0; z < array.GetLength(1) - 1; z++ )
            {
                if(array[i,z] > array[i,z + 1])
                {
                    int temp = array[i,z];
                    array[i,z] = array[i,z + 1];
                    array[i,z + 1] = temp;
                }
            }
        }
    }
    return array;
}

Console.Write("Введите количество строк массива: ");
int A  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int B  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите min: ");
int min  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите max: ");
int max  = Convert.ToInt32(Console.ReadLine());

int[,] MyArray = CreateRandomTwoDemArray(A,B,min,max);
ShowArray(MyArray);
MyArray = BubleSorting(MyArray);
ShowArray(MyArray);
*/
//Задача 2
/*
int[,] CreateRandomTwoDemArray(int a, int b, int min, int max)
{
    int[,] newMatrix = new int[a,b];
    for(int i = 0; i < a; i++)
    {
        for(int j = 0; j < b; j++)
        {
            newMatrix[i,j] = new Random().Next(min, max + 1);
        }
    }
    
    return newMatrix;
}

void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindMinSum(int[,] array)
{
    int minStr = 0;
    int sum = 0;
    int minSum = 0;
    int i = 0;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        sum = sum + array[i,j];
        minSum = sum;
    }
    sum = 0;
    for(i = 0; i < array.GetLength(0); i++)
    {
        
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        if(minSum > sum)
        {
            minSum = sum;
            minStr = i;
        }
        Console.WriteLine("Sum " + sum);
        sum = 0;
    }

    Console.Write("Минимальная сумма элементов в " + minStr + " строке.");
    
}

Console.Write("Введите количество строк массива: ");
int A  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int B  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите min: ");
int min  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите max: ");
int max  = Convert.ToInt32(Console.ReadLine());

int[,] MyArray = CreateRandomTwoDemArray(A,B,min,max);
ShowArray(MyArray);
FindMinSum(MyArray);
*/
// Задача 3
int [,] spiral(int a, int b)
{
    int[,] array = new int[a,b];
    int i = 0;
    int j = 0;
    int current = 1;
    int sizeStr = array.GetLength(0);
    int sizeCol = array.GetLength(1);
    for(j = 0; j < sizeCol; j++)
    {
        array[i,j] = current;
        current++;
    }
    for (i = 1; i < sizeStr; i++ )
    {
        array[i,3] = current;
        current++;
    }
    for(j = 2; j >= 0; j-- )
    {
        array[3,j] = current;
        current++;
    }
    for(i = 2; i > 0; i--)
    {
        array[i,0] = current;
        current++;
    }
    for(j = 1; j < sizeCol - 1;j++)
    {
        array[1,j] = current;
        current++;
    }
    array[2,2] = 15;
    array[2,1] = 16;

    
return array;
}
     
void ShowArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


ShowArray(spiral(4,4)); // Неужели есть алгоритм который заполнит спиралью любой заданный размер?
