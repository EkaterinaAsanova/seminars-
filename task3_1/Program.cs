// Проверка вводимого значения пользователя на ввод числа или строки

string text = Console.ReadLine();
int number;
bool success = int.TryParse(text, out number);
Console.WriteLine(success + " " + number);