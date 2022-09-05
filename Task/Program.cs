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
        Console.WriteLine($"Введите {i + 1} элемент массива:");
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
    if (array[i].Length <= 3) j = j + 1;
}

void GetNewArray(int l, string[] inArray1)
{
    string[] new_result = new string[l];

    for (int i = 0; i < new_result.Length; i++)
    {
        for (int k = 0; k < inArray1.Length; k++)
        {
            if (inArray1[k].Length <= 3)
            {
                new_result[i] = inArray1[k];
                inArray1[k] = "1111";
                break;
            }
        }
    }
    Console.WriteLine("Ваш новый массив : ");
    PrintArray(new_result);
}
GetNewArray(j, array);
