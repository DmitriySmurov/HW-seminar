// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число а");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень b");
int b = Convert.ToInt32(Console.ReadLine());

int step = a;

for (int i = 1; i < b; i++)
{
    step = step * a;
}
Console.WriteLine(" a в степени b =" + step );
