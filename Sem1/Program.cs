/*int num1, qwad, num2;

 Console.WriteLine ("Input first integer num ");
 num1 = Convert.ToInt32(Console.ReadLine ());
  Console.WriteLine ("Input second integer num ");
 num2 = Convert.ToInt32(Console.ReadLine ());

qwad = num2 * num2;

if ( qwad == num1)
{
    Console.WriteLine ( "Верное выражение!");
}
else
{
    Console.WriteLine ("Хуевое выражение!!");
}
*/

int num, current;

 Console.Write ("Input integer num ");
 num = Convert.ToInt32(Console.ReadLine ());

current = num * (-1);

while (current <= num)
{
Console.Write (current + " ");
current++;
}
