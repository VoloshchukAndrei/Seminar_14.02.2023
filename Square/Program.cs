Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine()!);

if(a * a == b)
{
    Console.Write("b квадрат a");
}
else if (Math.Pow(b, 2) == a)
{
    Console.Write("a квадрат b");
}
else
{
   Console.Write("Одно число не является квадратом другого"); 
}