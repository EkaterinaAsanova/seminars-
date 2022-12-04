// Программа принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 16 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine ("Введите число");
int a = Convert.ToInt32 (Console.ReadLine());
if (a%7==0 && a%23==0)
Console.WriteLine ("Число {0} кратное и 7 и 23", a);
else
Console.WriteLine ("Число {0} не кратное и 7 и 23", a);