string[] GetArray(int n)
{
    string[] startArray = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите {i + 1}-й элемент массива: ");
        startArray[i] = Console.ReadLine();
    }
    return startArray;
}

int GetLengthNewArray(string[] array1)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3) count++;
    }
    return count;
}

string[] GetNewArray(string[] array2, int m)
{
    string[] mass = new string[m];
    int count = 0;
    for (int i = 0; i < array2.Length; i++)
    {
        if (array2[i].Length <= 3)
        {
            mass[count] = array2[i];
            count++;
        }
    }
    return mass;
}

void PrintArray(string[] array)
{
    Console.WriteLine($" ['{String.Join("', '", array)}']");
}


Console.Write("Введите количество элементов массива: ");
int startLength = int.Parse(Console.ReadLine());
string[] startArray = GetArray(startLength);
int newLength = GetLengthNewArray(startArray);
string[] newArray = GetNewArray(startArray, newLength);
Console.WriteLine("Введенный массив: ");
PrintArray(startArray);
Console.WriteLine("Новый массив: ");
PrintArray(newArray);
Console.WriteLine();
