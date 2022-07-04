 // Задача 1
/*
 double[,] NewCreateTwoDemArrayRealNum(int a, int b)
{
    Random random = new Random();
    double[,] myArray = new double[a,b];
    for( int i = 0; i < a; i++)
    {
        for( int j = 0; j < b; j++)
        {
            myArray[i,j] =  Math.Round(-10 + random.NextDouble() * (10 + 10) , 2);
            Console.Write(myArray[i,j] + " ");
        }
        Console.WriteLine();
    }

    return myArray;
}

Console.Write("Введите количество строк массива: ");
int A  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int B  = Convert.ToInt32(Console.ReadLine());
NewCreateTwoDemArrayRealNum(A,B); */

// Задача 2

/*int[,] CreateRandomTwoDemArray(int a, int b, int min, int max)
{
    int[,] newMatrix = new int[a,b];
    for(int i = 0; i < a; i++)
    {
        Console.WriteLine();
        for(int j = 0; j < b; j++)
        {
            newMatrix[i,j] = new Random().Next(min, max + 1);
            Console.Write(newMatrix[i,j] + " ");
            
        }
    }
    
    Console.WriteLine();
    return newMatrix;
}

void FindElements( int[,] array, int a, int b)
{
    int i;
    int j = 0;
    for( i = 0; i < array.GetLength(0); i++)
    {
        for(j = 0; j  < array.GetLength(1); j++)
        {
            if(a == i && b == j)
            {
                Console.Write("Искомый элемент: " + array[i,j]);
            }
        }
    }
    if(a > i || b > j) Console.Write("Данного элемента нет в массиве!");
}

Console.Write("Введите количество строк массива: ");
int A  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int B  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите min: ");
int min  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите max: ");
int max  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите адрес строки: ");
int s  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите адрес столбца: ");
int c  = Convert.ToInt32(Console.ReadLine());
FindElements(CreateRandomTwoDemArray(A,B,min,max),s,c);*/

// Задача 3
double ArithmeticMeanColumn(int[,] array)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    double avereng = 0;
    for( int j = 0; j < array.GetLength(1); j++)
    {
        for( int i = 0; i < array.GetLength(0); i++)
        {
            avereng = (avereng + array[i,j]);
        }
        avereng = avereng / array.GetLength(1);
        Console.Write((Math.Round(avereng,1) + "; "));
        avereng = 0;
    }
    return avereng;
}

int[,] CreateRandomTwoDemArray(int a, int b, int min, int max)
{
    int[,] newMatrix = new int[a,b];
    for(int i = 0; i < a; i++)
    {
        Console.WriteLine();
        for(int j = 0; j < b; j++)
        {
            newMatrix[i,j] = new Random().Next(min, max + 1);
            Console.Write(newMatrix[i,j] + " ");
            
        }
    }
    
    Console.WriteLine();
    return newMatrix;
}

Console.Write("Введите количество строк массива: ");
int A  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int B  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите min: ");
int min  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите max: ");
int max  = Convert.ToInt32(Console.ReadLine());
ArithmeticMeanColumn(CreateRandomTwoDemArray(A,B,min,max));