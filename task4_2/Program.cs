// Задача №26 Напишите программу, которая принимает на вход число и выдает количество цифр в числе. 
// 456 = 3
// 78 = 2
// 876544 = 6

Console.WriteLine("Введите число");
 int number = Convert.ToInt32(Console.ReadLine());
 int count = 0;
 while (number > 0)
 {
number/=10;
count ++;    
 }
 Console.WriteLine("Количество цифр:" +count);