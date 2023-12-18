// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void PrintArray(string[] array)
{   
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write("\b\b");
    Console.Write("]");
}

Console.WriteLine("Сколько элементов массива Вы хотите ввести?");
int length = Convert.ToInt32(Console.ReadLine());
string[] array = new string[length];

for (int i = 0; i < array.Length; i++)
{
    array[i] = Console.ReadLine();
}

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3) count++;
}

string[] finalArray = new string[count];

int countSecond = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        finalArray[countSecond] = array[i];
        countSecond++;
    }
}

PrintArray(array);
Console.WriteLine();
PrintArray(finalArray);
