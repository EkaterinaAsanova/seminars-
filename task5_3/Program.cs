// Задача №33 Задайте массив. Напишите программу, которая определяет присутствует ли заданное число в массиве.
// Число 4. [3,5,6,-1] - нет
// Число 5. [3,5,6,-1] - да

Console.WriteLine("Введите искомое число");
 int n = Convert.ToInt32(Console.ReadLine());
Random random = new Random();//Создали экземпляр класса Random, чтобы генерировать случайные числа
int[] array = new int[12]; //Создали массив на 12 элементов с именем array
for (int i = 0; i < array.Length; i++)//Создали цикл, чтобы пройтись по каждому элементу array
{
    array[i] = random.Next(-10,11);//Заполняем одну ячейку array случайным числом от -9 до 9. 
}
Console.WriteLine(string.Join(",", array));
Console.WriteLine(FindElement(array,n));

bool FindElement (int [] array, int n)
{
    bool count=false;
    for (int i = 0; i < array.Length; i++)
    if (array[i]==n)
    count=true; 
    return count;
}

