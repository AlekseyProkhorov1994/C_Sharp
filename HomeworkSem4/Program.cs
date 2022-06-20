//Задача 1

/*void NumberPower(int num1, int num2)
{
    if(num2 <= 0) 
    {
        Console.Write("Error, unnatural number!!!");
    }
    else
    {
        int current = 1;
        int result = 1;
        while(current <= num2)
        {
            result = result * num1;
            current++;
        }
        Console.Write(result);
    }
}

Console.Write("Input num A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input num B: ");
int b = Convert.ToInt32(Console.ReadLine());
NumberPower(a,b);*/

//Задача 2

void arrey8()
{
    int size = 8;
    int[] arrey = new int[size];
    for( int i = 0; i < size; i++)
    {
        arrey[i] = new Random().Next(0, 100);
    }
    for(int i = 0; i < size; i++)
    {
       Console.Write(arrey[i] + " ");
    }
}

arrey8();