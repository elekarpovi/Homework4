//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();

System.Console.WriteLine("Введите два числа: A и B. Число B должно быть натуральным!");
System.Console.WriteLine("Число A: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int mult = 1;

if (b >= 1)

{
    for ( int i = 1; i <= b; i++)
    mult = mult * a;
    System.Console.WriteLine($"{a} в степени {b} = {mult}");
}

else
System.Console.WriteLine("Ошибка. Введите число B больше либо равно 1!");


