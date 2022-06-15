// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] stringArray = { "Hello", "2", "world", ":-)" };

// создание нового массива
string[] CreateArray(string[] array)
{
    int length = array.Length;
    string[] newArray = new string[length];
    return newArray;
}

// заполнение нового массива c элементами, длинна которых меньше либо равна 3 с последующим сокращением размера нового массива
string[] FillAndCutArray(string[] array, string[] newArray)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    Array.Resize(ref newArray, j);
    return newArray;
}

// печать массива
void PrintArray(string[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write($"'{newArray[i]}'");
    }
}

string[] resultArray = CreateArray(stringArray);
resultArray = FillAndCutArray (stringArray, resultArray);
Console.WriteLine("Массив из строк, длина которых меньше, либо равна 3 символам:");
PrintArray(resultArray);

