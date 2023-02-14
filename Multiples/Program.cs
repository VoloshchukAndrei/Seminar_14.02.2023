Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine()!);
int result = numberA % numberB;
if(result == 0)
{
    Console.Write("Числа являются кратными");
}
else
{
   Console.Write("Числа не являются кратными, остаток " + result); 
}