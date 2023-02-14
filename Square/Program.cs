Console.Write("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine()!);

if((numberA / numberB == numberB) || (numberB / numberA == numberA)) // || - или
{
    Console.Write("Одно число является квадратом другого");
}
else
{
   Console.Write("Одно число не является квадратом другого"); 
}