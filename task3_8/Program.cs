// Задача 21. Напишите программу, которая принимает на вход координаты 2х точек и находит расстояние в 2D пространстве.
// А(3,6);В(2,1)  =  5.09
// А(7,-5);В(1,-1)  =  7.21
// с использованием массива! 

double ab=0;
double [] point = new double[4];
for (int i=0; i< point.Length; i++)
point[i]=Convert.ToDouble(Console.ReadLine());

ab = Math.Sqrt((point[0]-point[2])*(point[0]-point[2]) + (point[1]-point[3])*(point[1]-point[3]));
Console.WriteLine(ab); 
