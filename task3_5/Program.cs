// Задача 18. Напишите программу ,которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (Х и У)

int kord;
Console.WriteLine("Введите номер четверти");
kord = Convert.ToInt32(Console.ReadLine());
if (kord==1)
Console.WriteLine ("x > 0 , y > 0");
if (kord==2)
Console.WriteLine ("x < 0 , y > 0");
if (kord==3)
Console.WriteLine ("x < 0 , y < 0");
if (kord==4)
Console.WriteLine ("x > 0 , y < 0");
if (kord >4 || kord <1)
Console.WriteLine ("Введите четверти от 1 до 4");