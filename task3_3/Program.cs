// Математический метод к задаче №13. Вывод 3 цифры если ее нет, то сообщить об ошибке

int number= Convert.ToInt32(Console.ReadLine());
int result = 0;
if (number>999)
    while (number>999)
    number =number / 10;
if (number < 1000 && number > 99)
result = number % 10;
//125%10 = 5
// 142124 /10 = 14212
// 14212 / 10 = 1421
// 1421 / 10 = 142
// 142 % 10 =2
Console.WriteLine (result);
