// Первая задача
/*int FindMiddle(int num)
{
    if(num > 99 && num < 1000)
    {
        return  num % 100 / 10;
    }
    else return -1;
}

Console.Write("Input three-digit number ");
 int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(FindMiddle(a));
*/



// Вторая задача
/*int СutThree(int num)
{
    if(num > 99)
    {
        while(num > 999)
        {
            num = num / 10;
        }
        return num % 10;
    }
    else
    {
        return -1;
    }
}

Console.WriteLine("Input num ");
int a = Convert.ToInt32(Console.ReadLine());

if(СutThree(a) == (-1))
{
    Console.WriteLine("Третьей цыфры нет!");
}
else
{
    Console.WriteLine(СutThree(a));
}
*/


//Третья задача
/*string DayOfWeek(int num)
{
    if(num >= 1 && num <= 7)
    {
        if(num > 5)
        {
            return "Yes";
        }else return "No";
    }
    else return "There are only 7 days in a week!";

}

Console.Write("Input number day ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(DayOfWeek(a));
*/