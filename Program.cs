// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями. лучше обойтись исключительно массивами.

Console.Clear();

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = Convert.ToString(Console.ReadLine());
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void FilterArray(string[] array, ref string[] filteredArray)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4 ) 
        {
            Array.Resize(ref filteredArray, filteredArray.Length + 1);
            filteredArray[filteredArray.Length - 1] = array[i];
        }
    }
}


string[] array = new string[4];
string[] filteredArray = new string [0]; 

FillArray(array);
Console.WriteLine();
Console.Write("Начальный массив: ");
PrintArray(array);
FilterArray(array, ref filteredArray);
Console.WriteLine();
Console.Write("Конечный массив: ");
PrintArray(filteredArray);

