// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.


Console.WriteLine("Введите количество элементов массива: ");
int number = int.Parse(Console.ReadLine());

string[] GetArray(int n)
{
    string[] result = new string[n];

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine($"Введите {i+1} элемент массива:");
        result[i] = Console.ReadLine();
    }
    return result;
}

void PrintArray(string[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($" {inArray[i]} ");
    }
}

string[] array = GetArray(number);

Console.WriteLine("Ваш массив : ");
PrintArray(array);

Console.WriteLine();

int j = 0;
for (int i = 0; i < array.Length; i++)
{
   if (array[i].Length == 3) j = j + 1;
}

Console.WriteLine(j);