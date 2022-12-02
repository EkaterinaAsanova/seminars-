// Программа на вход принимает 2 числа и проверяет, является ли первое число квадратом второго

int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1==number2*number2)
{
    Console.WriteLine ("Yes");
}
else
{
    Console.WriteLine ("No");
}