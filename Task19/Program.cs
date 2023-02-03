// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();

// если нужно только 5-значное число
// while(true)
// {
//     System.Console.Write("Enter your number: ");
//     int number = int.Parse(Console.ReadLine());
//     if(number >= 99999 || number <= 10000)
//     {
//         System.Console.Write("You have entered a wrong number. ");
//     }
//     else if(number <= 99999 && number >= 10000)
//     {
//         break;
//     }
// }

// любое число

// Вариант 1

System.Console.Write("Enter your number: "); 
int number = int.Parse(Console.ReadLine());

while(number > 9)
{
    int numEnd = number%10;
    int numStart = 0;
    int count = 1;
    int i = number;

    while(number > 9)
    {
        number = number/10;
        count = count * 10;
    }

    numStart = number;
    if(numStart != numEnd)
    {
        System.Console.WriteLine("Not a palindrome");
        return;
    }
    else
    {
        number = (i - count*number)/10;
    }
      
}
System.Console.WriteLine("Palindrome");

// Вариант 2

// System.Console.Write("Enter your number: "); 
// int number = int.Parse(Console.ReadLine());

// int number2 = number%10;
// int i = number;

// while(number > 9)
// {
//     number = number/10;
//     number2 = number2 * 10 + number%10;
// }

// System.Console.WriteLine(number2);

// number = i;

// if(number == number2)
// {
//     System.Console.WriteLine("Palindrome");
// }
// else
// {
//     System.Console.WriteLine("NOT a palindrome");
// }