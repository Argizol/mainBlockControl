Console.Clear();
string[] array = { "Hello", "2", "world", "!!!" };
PrintArray(array);
Console.Write(" -> ");

int sizeNewArray = ArrLength(array);

string[] result = NewArray(array);

PrintArray(result);

int ArrLength(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}

string[] NewArray(string[] array)
{
    int index = 0;
    string[] result = new string[sizeNewArray];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            result[index] = array[i];
            index++;
        }
    }
    return result;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}