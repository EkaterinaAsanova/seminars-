﻿// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, 
//второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.WriteLine("Input array length");
int length = Convert.ToInt32(Console.ReadLine());//Ввели длину массива
int[] array = new int[length];//Создали массив, длина которого = Length
for (int i = 0; i < length; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());//Заполняем массив происпольными числами
}
Console.WriteLine(Multiply(array));

string Multiply(int[] array)//Функция по перемножению парных чисел
{
    string text = "";//Переменная для вывода
    for (int i = 0; i < array.Length / 2; i++)// i < array.Length / 2, т.к мы берем парные числа, 
    // то операций будет в 2 раза меньше
    {
        text += (array[i] * array[array.Length - i - 1]) + " ";
        //Взяли число слева, взяли число справа и соединили со строковой
        //Левый диапазон оставляем как есть i
        //Правый дипапазон length-i-1, потому что 
        //length - длина массива. Значит последний элемент по индексу length - 1
        //Чтобы диапазон справа смещался, необходимо добавить - i
        //Итого length - i - 1
    }
    if (array.Length % 2 == 1)//Условие, что определять четное или нечетное количество элементов
        text += array[array.Length / 2]; 
    //Пример [1,2,3,4,5]. Длина - 5, 5/2 = 2. array[2] - это третий элемент с индексом 2, т.е середина.
    return text;
}