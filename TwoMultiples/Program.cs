Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if((number % 7 == 0) && (number % 23 == 0)) // && - и
{
    Console.Write("Число является кратным числам 7 и 23");
}
else
{
   Console.Write("Число не является кратным числам 7 и 23"); 
}