// Задача 1 
/*
int SumNumGap ( int n, int m)
{   
    int sum = 0;
    if(n >= m) return m + SumNumGap(n,m + 1);

    return sum;
}
Console.Write("Введите число нижний диапозон: ");
int m  = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите верхний диапозон: ");
int n  = Convert.ToInt32(Console.ReadLine());
Console.Write("Сумма = " + SumNumGap(n,m));*/


// Задача 2

int CounterNum (int num)
{
    int count = 0;
    if(num < 0)
    {
        num = - num;
        if(num > 0) count = num - (num  - 1)  +  CounterNum(num / 10);
            return  count;
    }
    else
    {
            if(num > 0) count = num - (num  - 1)  +  CounterNum(num / 10);
            return  count;
    }
    
}

Console.Write("Введите число: ");
int a  = Convert.ToInt32(Console.ReadLine());
Console.Write(CounterNum (a));
