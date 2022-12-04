//Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа

Random random = new Random();
int number = 0;
number = random.Next(10, 100);
Console.WriteLine(number);
int a = number / 10;
int b = number % 10;
Console.WriteLine("{0} {1}", a, b);
if (a>b)
  Console.WriteLine("a>b");
else if (b>a)
       Console.WriteLine("b>a");
      else if (b==a)
             Console.WriteLine("b==a");