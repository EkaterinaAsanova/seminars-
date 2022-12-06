// Задача 21. Напишите программу, которая принимает на вход координаты 2х точек и находит расстояние в 2D пространстве.
// А(3,6);В(2,1)  =  5.09
// А(7,-5);В(1,-1)  =  7.21

double x=0, y=0,x1=0,y1=0, ab=0;
x = Convert.ToDouble(Console.ReadLine());
y = Convert.ToDouble(Console.ReadLine());
x1 = Convert.ToDouble(Console.ReadLine());
y1 = Convert.ToDouble(Console.ReadLine());

ab = Math.Sqrt((x1-x)*(x1-x) + (y1-y)*(y1-y));
Console.WriteLine(ab); 