// Написать программу, которая из имеющегося массива строк формирует новый массив 
// из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив 
// можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


Console.Clear();

string[] LimitCharsOfArray(string[] array, int limit)
{
    string[] newArray = new string[array.Length];
    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < limit)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

void PrintArray(string[] array)
{
    bool firstElement = true;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != null && array[i] != "")
        {
            if (!firstElement)
            {
                Console.Write(", ");
            }
            Console.Write($"{array[i]}");
            firstElement = false;
        }
    }
}

Console.WriteLine("Enter the array size");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = new string[size];
Console.WriteLine($"Enter the {size} array items");
for (int i = 0; i < array.Length; i++)
{
    array[i] = Console.ReadLine();
}

string[] newArray = LimitCharsOfArray(array, 4);

PrintArray(newArray);








// string[] array = new string[size];

// string[] newArray = new string[size];
// int j = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     Console.WriteLine("Enter the array item");
//     array[i] = Console.ReadLine();
//     if (array[i].Length < 4)
//     {
//         newArray[j] = array[i];
//         j++;
//     }
// }

// bool firstElement = true;
// for (int i = 0; i < newArray.Length; i++)
// {
//     if (newArray[i] != null && array[i] != "")
//     {
//         if (!firstElement)
//         {
//             Console.Write(", ");
//         }
//         Console.Write($"{newArray[i]}");
//         firstElement = false;
//     }
// }