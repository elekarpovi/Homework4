//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear();

System.Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int x;

if (a < 0) a = Math.Abs(a);
while (a > 0)
{
    x = a % 10;
    sum = sum + x;
    a = a / 10;
}


Console.WriteLine($"Сумма цифр в числе = {sum}");
