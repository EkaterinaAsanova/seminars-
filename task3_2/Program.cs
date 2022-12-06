// Решение задачи №10 математическим методом
// из трехзначного числа показывать 2 цифру

int number = Convert.ToInt32(Console.ReadLine());
if ((number < 1000 && number > 99) || (number > - 1000 && number < -99))
{
    number = number /10 % 10;
// 945 /10; 94*10 = 940
// 94 % 10 = 9*10 = 90 . 4 цифра 4 и есть 2 позиция в трехзначном числе

    Console.WriteLine (number);
}
else
Console.WriteLine ("error");