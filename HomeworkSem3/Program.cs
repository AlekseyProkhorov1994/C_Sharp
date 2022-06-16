// Первая задача

/*string palindrome(int num)
{
    if(num < 10000) return "Error, incorrect number"; // изначальная версия была с объединенными условиями 5 и 6 строки 
    if(num > 99999) return "Error, incorrect number"; // через логическое "&&", при проверке, не одно из условий не работало:(
    if(num == 0) return "Error, incorrect number";
    if((num / 10000) == (num % 10) && (num / 1000 % 10) == (num % 100 / 10)) return "Yes";
    else return "No";
}

Console.Write("Input num: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a < 0) a = a * (-1);
Console.Write(palindrome(a));
*/



// Вторая задача

/*double FindLenght_3D(double xA, double yA, double zA, double xB, double yB, double zB)
{
    return Math.Sqrt(Math.Pow((xB - xA),2) + Math.Pow((yB - yA),2) + Math.Pow((zB - zA),2));
}

Console.Write("Input num A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input num B: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input num C: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Input num D: ");
int d = Convert.ToInt32(Console.ReadLine());
Console.Write("Input num F: ");
int f = Convert.ToInt32(Console.ReadLine());
Console.Write("Input num G: ");
int g = Convert.ToInt32(Console.ReadLine());
Console.Write(FindLenght_3D(a,b,c,d,f,g));
*/


//Третья задача

void TableOfCubes(int num)
{
    int current = 1;
    while(current <= num)
    {
        int resulte = current * current * current;
        Console.Write($"{resulte} ");
        current = current + 1;
    }
}

Console.Write("Input num: ");
int a = Convert.ToInt32(Console.ReadLine());
while(a <= 0)
{
    Console.Write("Error, incorrect number, input num: ");
    a = Convert.ToInt32(Console.ReadLine());
}
TableOfCubes(a);