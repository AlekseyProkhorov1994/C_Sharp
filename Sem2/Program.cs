/*int FindeMaxPart(int num)
{
    int dec, ed;
    if(num >= 10 && num < 100)
    { 
        dec = num / 10;
        ed = num % 10;
        if(dec > ed)
        {
            return dec;
        }
        else
        {
            return ed;
        }
    }
    else
    {
        return  -1;
    }
}

Console.Write("Input two-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = FindeMaxPart(a);

if(result == -1)
{
    Console.Write("Error, num not two-digital");
}
else
{
Console.Write($"Bigger num of  {a} is {result}");
}
*/

/*int DeletSecondNum(int num1)
{
    int num2 = num1 / 100 * 10 + (num1 % 10);
    return num2;
}
int a = new Random().Next(100, 1000);
int result = DeletSecondNum(a);

if(a > 999)
{
    Console.WriteLine(a);
    Console.Write("Error, random loh");
}
else
{
Console.WriteLine(a);
Console.Write(result);
}
*/

int Metod(int num1,int num2)
{
    if(num2 % num1 == 0)
    {
        return 10;
    }
    else
    {
         num2 = num2 % num1;

        return num2;
    }
}

Console.Write("Input first number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input second number: ");
int b = Convert.ToInt32(Console.ReadLine());
int result = Metod(a,b);
if(result ==10)
{
    Console.Write("Kratnoe");
}
else
{
    Console.Write(result);
}
