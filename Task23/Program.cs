// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();

System.Console.Write("Enter your number: ");
int number = int.Parse(Console.ReadLine());

int number2 = 1;

while(number >= number2)
{
    System.Console.Write($"{number2}  ");
    double sqr3 = Math.Pow(number2,3);
    System.Console.WriteLine(sqr3);
    number2++;
}
