//Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

// Random array = new Random(); можно не использовать 
// int [] n = new int [8];
// for (int i=0; i<n.Length;i++)
// {
//     n[i] = new Random().Next(0,2);
//     Console.Write(" " +n[i]);
// }

// // 2 вариант решения задачи

// nt[] Array(int[] mass)
// {
// int Length = mass.Length;
// int index = 0;
// while (index < Length)
// {
// mass [index] = new Random().Next(0,2);
// index++;
// }return mass;
// }
// int []ok = new int[8];
// string text = string.Join(",",Array(ok));
// Console.WriteLine(text);

// 3 вариант 
//Random a = new Random(); // штука позволяющая получить рандомное число
Random b = new Random(); 
//string b;
//int c;
//Console.WriteLine(outputArray(b)); // вывели результат работыcd

string outputArray(Random random) // функция для вывода случайных чисел
{
    int[] numerals = new int [8]; // создали массив из 8 чисел
    for (int i=0; i < numerals.Length; i++) // цикл по заполнению массива 0 и 1
    {
        numerals[i] = random.Next(0,2); // запись в ячейку массива рандомного числа от 0 до 1
    }
    string output; // создали текст для вывода
    return output = string.Join(",", numerals); // Соединили массив в строку , элементы разделены запятой 
}
Console.WriteLine(outputArray(b));