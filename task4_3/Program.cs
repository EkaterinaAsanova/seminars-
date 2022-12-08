//Решение в группах задач:
//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120


// Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());
// int Proizv(int M){int pz=1; while (1!=M){pz=pz*M;M--;}return pz;}
// Console.WriteLine(Proizv(n));


// 2 способ решения задачи. BigInteger тип переменной с неограниченным диапозоном значений 

using System.Numerics;
Console.WriteLine("Введите число");
int n =Convert.ToInt32(Console.ReadLine());
BigInteger Factorial(int n)
{
    var factorial = new BigInteger (1);
    for (int i = 1; i <= n; i++)
    factorial *= i;

return factorial;
}
Console.WriteLine(Factorial(n));


