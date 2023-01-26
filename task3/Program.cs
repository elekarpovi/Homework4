//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1. Вариант для ручного ввода.

//Console.Clear();              


//System.Console.WriteLine("Введите восемь элементов массива.");
//System.Console.Write("Первый элемент: ");
//int a = Convert.ToInt32(Console.ReadLine());

//System.Console.Write("Второй элемент: ");
//int b = Convert.ToInt32(Console.ReadLine());

//System.Console.Write("Третий элемент: ");
//int c = Convert.ToInt32(Console.ReadLine());

//System.Console.Write("Четвертый элемент: ");
//int d = Convert.ToInt32(Console.ReadLine());

//System.Console.Write("Пятый элемент: ");
//int e = Convert.ToInt32(Console.ReadLine());

//System.Console.Write("Шестой элемент: ");
//int f = Convert.ToInt32(Console.ReadLine());

//System.Console.Write("Седьмой элемент: ");
//int g = Convert.ToInt32(Console.ReadLine());

//System.Console.Write("Восьмой элемент: ");
//int h = Convert.ToInt32(Console.ReadLine());

//int [] array = {a, b, c, d, e, f, g, h};
//System.Console.Write($"{array[0]}, {array[1]}, {array[2]}, {array[3]}, {array[4]}, {array[5]}, {array[6]}, {array[7]}");



//2. Вариант для автоматического ввода.
Console.Clear();
int [] array = new int[8];
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection [index] = new Random().Next(-1000, 1000);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        System.Console.WriteLine(col [position]);
        position++;
    }
}


FillArray(array);
PrintArray(array);