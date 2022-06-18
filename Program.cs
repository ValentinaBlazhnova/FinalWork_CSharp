/// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// [hello, 2 world, :-)] -> [2, :-)]
// [1234, 1567, -2, computer science] -> [-2]
// [Russia, Denmark, Kazan] -> []

Console.WriteLine("Введите 4 элемента массива через Enter: ");
string[] array = new string[4];

FillArray(array);
PrintArray(array);

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
    array[i] = Convert.ToString(Console.ReadLine());
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
    Console.Write(array[i] + " ");
    }
}

int sizeNewArray = 0;
string[] FillNewArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            sizeNewArray++;
        }
    }

    string[] newArray = new string[sizeNewArray];
    for (int i = 0, j = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

Console.WriteLine();
FillNewArray(array);
Console.Write("Новый массив: ");
PrintArray(FillNewArray(array));
