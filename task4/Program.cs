// Программа на вход принимает одно число N, а на выходе показывает все целые числа в промежутку от -N до N (4: -4,-3, -2 ...3, 4)
int N= int.Parse(Console.ReadLine());
int M=-N;
while (M<=N)
{
    Console.WriteLine(M++);
    }