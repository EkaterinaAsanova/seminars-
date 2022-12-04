// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
// 456->46
// 782->72
// 918 ->98

Random random = new Random();
int number = 0;
number = random.Next(100, 1000);
Console.WriteLine(number);
int a = number /100;
int b = number % 10;

Console.WriteLine("Двухзначное число:" +a+b);