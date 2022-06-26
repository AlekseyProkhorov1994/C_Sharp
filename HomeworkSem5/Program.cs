// Задача 1
/*
int[] CreateArray(int size)
{
    int[] NewArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        NewArray[i] = new Random().Next(100, 1000);
        Console.Write(NewArray[i] + " "); 
    }
    Console.WriteLine();
    return NewArray;
}

int EveneElementsArray(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0) count++;
    }
    return count;
}

Console.Write("Введите размер массива: ");
int a  = Convert.ToInt32(Console.ReadLine());
if(a <= 0)
{
    Console.Write("Некорректный размер массива");
}
else
{
    Console.Write("В данном массиве: " + EveneElementsArray(CreateArray(a)) + " четных элементов");
}

*/
/*
int[] NewRandomArray(int size, int min, int max)
{
    int[] MyArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        MyArray[i] = new Random().Next(min, max + 1);
        Console.Write(MyArray[i] +  " ");
    }
    Console.WriteLine();
    return MyArray;
}

int SumOddArray(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    Console.Write("Сумма элементов, находящихся на нечетных позициях массива равна: " + sum);
    return sum;
}
Console.Write("Введите размер массива: ");
int size  = Convert.ToInt32(Console.ReadLine());
if(size < 2)
{
    Console.Write("Некорректный размер массива!");
}
else
{
    Console.Write("Введите нижний предел массива: ");
    int min  = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите верхний предел массива: ");
    int max  = Convert.ToInt32(Console.ReadLine());
    SumOddArray(NewRandomArray(size,min,max));
}
*/

// Задача 3

double[] RealNumArray (int size)
{
    double[] RealNumArray = new double[size];
    for(int i = 0; i < size; i++)
    {
        RealNumArray[i] = Math.Round(new Random().NextDouble(),2);
        Console.Write(RealNumArray[i] +  "   ");
    }

    Console.WriteLine();
    
    return RealNumArray;

}

double DifferenceBetweenMaxMin (double[] array)
{   
    double max = array[0];
    double min = array[1];
    for( int i = 2; i < array.Length; i++) 
    {
        if(max >= min)
        {
            if(array[i] > max)
            {
                max = array[i];
            }
            if(array[i] < min)
            {
                min = array[i];
            }
        }
        else
        {
            max = array[1];
            min = array[0];
            if(array[i] > max)
            {
                max = array[i];
            }
            if(array[i] < min)
            {
                min = array[i];
            }
        }
    }
    double resulte = max - min;
    if(array.Length == 2)
    {
        if(min > max) resulte = min - max;
    }
    return resulte;
}

Console.Write("Введите размер массива: ");
int size  = Convert.ToInt32(Console.ReadLine());
if(size < 2)
{
    Console.Write("Неккоректный размер массива!");
}
else
{
    Console.Write("Разница между максимальным и минимальным элементом масства =  " + DifferenceBetweenMaxMin(RealNumArray(size)));
}
