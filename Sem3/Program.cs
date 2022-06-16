/*int Compas(int x,int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;

    return -1;
}

Console.Write("Input X: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write(Compas(a,b));
*/

/*void coordinate_range(int qwad)
{
    if(qwad > 0 && qwad < 5)
    {
        if(qwad == 1)Console.Write("Диапозон обоих координат x и y положительный");
        if(qwad == 3)Console.Write("Диапозон обоих координат x и y отрицательный");
        if(qwad == 2)Console.Write("Диапозон обоих координат x = x > 0 а, y = y < 0");
        if(qwad == 4)Console.Write("Диапозон обоих координат x = x < 0 а, y = y > 0");
    }
    else Console.Write("Введен не верный номер четверти");
}
Console.Write("Input coordinate range ");
int q = Convert.ToInt32(Console.ReadLine());
coordinate_range(q);
*/

/*void square_number(int num)
{
    int current = 1;
    while(current <= num)
    {
        int result = current * current;
        Console.Write($"{result} ");
        current = current + 1;
    }
}
Console.Write("Input N: ");
int N = Convert.ToInt32(Console.ReadLine());
square_number(N);
*/

double FindLenght(double xA, double yA, double xB, double yB)
{
    return Math.Sqrt(xB - xA)*(xB - xA) + Math.Pow((yB - yA),2);
}
