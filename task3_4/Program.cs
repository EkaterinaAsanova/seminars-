// Задача №17 Напишите программу, которая принимает на вход координаты точки (Х и У). 
// Причем Х не равно 0 и У не равно 0 и выдает номер четверки к которой она относится. 

int[] points = new int [2];

// ручной метод заполнения 
//points [0] = Convert.ToInt32(Console.ReadLine());
//points [1] = Convert.ToInt32(Console.ReadLine());

for (int i=0; i < points.Length; i++)
{
points[i] = Convert.ToInt32(Console.ReadLine());
}
 // points[0] - x , points [1] - y [x,y] x>0, y>0 = 1 четверть
if (points[0]>0 && points[1]>0)
    Console.WriteLine("1 четверть");
if (points[0]<0 && points[1]>0)
    Console.WriteLine("2 етверть");
if (points[0]<0 && points[1]<0)
    Console.WriteLine("3 четверть");
if (points[0]>0 && points[1]<0)
    Console.WriteLine("4 четверть");