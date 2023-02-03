// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 
// 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

System.Console.Write("Enter your 1st point X: ");
double point1X = double.Parse(Console.ReadLine());

System.Console.Write("Enter your 1st point Y: ");
double point1Y = double.Parse(Console.ReadLine());

System.Console.Write("Enter your 1st point Z: ");
double point1Z = double.Parse(Console.ReadLine());

System.Console.Write("Enter your 2nd point X: ");
double point2X = double.Parse(Console.ReadLine());

System.Console.Write("Enter your 2nd point Y: ");
double point2Y = double.Parse(Console.ReadLine());

System.Console.Write("Enter your 2nd point Z: ");
double point2Z = double.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((point1X - point2X),2) + Math.Pow((point1Y - point2Y),2) + Math.Pow((point1Z - point2Z),2)); // d = √ (х А – х В) 2 + (у А – у В) 2

System.Console.WriteLine(result.ToString("c2"));
