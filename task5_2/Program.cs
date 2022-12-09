// Задача №32 напишите программу для замены элементов массива : 
// положительные заменить на соответствующие отрицательные и наоборот.
// [-4.-8.8.2]= 4,8,-8,-2


Console.WriteLine("Введите длину массива");
 int n = Convert.ToInt32(Console.ReadLine());
Random random = new Random();//Создали экземпляр класса Random, чтобы генерировать случайные числа
int[] array = new int[n]; //Создали массив на 12 элементов с именем array

for (int i = 0; i < array.Length; i++)//Создали цикл, чтобы пройтись по каждому элементу array
{
    array[i] = random.Next(-10,11);//Заполняем одну ячейку array случайным числом от -9 до 9. 
}
Console.WriteLine(string.Join(",", array)); //Соединяем наш массив в строку, где элементы разделены запятой
Console.WriteLine(string.Join(",", SmenaZnaka(array)));

int [] SmenaZnaka(int[]array)//Функция для смены знака
{
    for (int i=0; i < array.Length; i++) // шаг для выполнения условия
    array[i] = -array[i]; 

    return array;
}