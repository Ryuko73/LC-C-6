
// Console.WriteLine("Введите числа: ");
// Console.ReadLine();
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
void Zadacha1()
{
    Console.WriteLine("Сколько чисел будем вводить? ");
    int NumbersCount = Convert.ToInt32(Console.ReadLine());
    int Count = 0;
    for (int i = 0; i < NumbersCount; i++)
    {
        Console.WriteLine("Введите числа ");
        int ZapisNumbers = Convert.ToInt32(Console.ReadLine());
        int index = 0;
        if (ZapisNumbers > 0) Count++;

    }
    Console.WriteLine($"Пользователь ввел {Count} чисел больше нуля ");
}
//Zadacha1();
//Напишите программу, которая найдёт точку пересечения двух прямых
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
void Zadacha2()
{
    Console.Write("Введите k1: ");
    var k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b1: ");
    var b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите k2: ");
    var k2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите b2: ");
    var b2 = Convert.ToDouble(Console.ReadLine());


    var x = -(b1 - b2) / (k1 - k2);
    var y = k1 * x + b1;

    x = Math.Round(x, 3);
    y = Math.Round(y, 3);

    Console.WriteLine($"Пересечение в точке: ({x};{y})");
}