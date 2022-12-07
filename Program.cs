/* Задача: 
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

string[] InputArrayString()
{
    int L = new Random().Next(1, 6);
    string[] array = new string[L];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Enter array element № {i + 1} = ");
        array[i] = Console.ReadLine();
        if (array[i] == "")
        {
            Console.WriteLine($"No new element in this turn. Try again.");
            i--;
        }
    }
    return array;
}
int ArrayNewCount(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}
string[] FillArray3LengthElements(int L, string[] array)
{
    string[] arrayNew = new string[L];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayNew[j] = array[i];
            j++;
        }
    }
    return arrayNew;
}
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Console.Write("\"" + array[i] + "\"");
        }
        else
        {
            Console.Write("\"" + array[i] + "\", ");
        }
    }
    Console.WriteLine("]");
}

string[] arrayStart = InputArrayString();
Console.WriteLine("Starting array:");
PrintArray(arrayStart);
int count = ArrayNewCount(arrayStart);
string[] arrayResult = FillArray3LengthElements(count, arrayStart);
Console.WriteLine("Array result filled with elements of the starting array containing no more than three characters:");
PrintArray(arrayResult);