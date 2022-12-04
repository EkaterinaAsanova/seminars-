// Напишите программу, которая будет принимать на вход два числа и выводить является ли первое число кратным второму.
// Если число 1 не кратно числу 2, то программа выводит остаток от деления. 
// 34 -> не кратно, остаток 4. 

Console.WriteLine ("Введите первое число");
int a = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите второе число");
int b = Convert.ToInt32 (Console.ReadLine());
int n=0;
if (a%b==0)
    Console.WriteLine ("Число кратное");
else
{
    n = a%b;
    Console.WriteLine ("Число {0} некратное числу {1}", a, b );
    Console.WriteLine ("Остаток от деления:" +n);
}

