// Задача 1

/*int CounterPositive(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) count++;
    }
    Console.Write("Among the entered numbers: " + count + " positive");
    return count;
}

int[] UserNum(int size)
{
    int[] MyArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        Console.Write("Input num: ");
        MyArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return MyArray;
}

Console.Write("Input number of numbers: ");
int m = Convert.ToInt32(Console.ReadLine());
CounterPositive(UserNum(m));*/

// Задача 2

int[] CopyArray(int[] array)
{
    int[] MyArray = new int [array.Length];
    for(int i = 0; i < array.Length; i++)
    {
       MyArray[i] = array[i];
       Console.Write(MyArray[i] + " ");
    }
    return MyArray;
}

int[] CreateArray(int size)
{
    int[] NewArray = new int[size];
    for(int i = 0; i < size; i++)
    {
        NewArray[i] = new Random().Next(10, 1000);
        Console.Write(NewArray[i] + " "); 
    }
    Console.WriteLine();
    return NewArray;
}   

Console.Write("Введите размер массива: ");
int a  = Convert.ToInt32(Console.ReadLine());
CopyArray(CreateArray(a));
