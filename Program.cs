using System.Text;

string[] array = { "Hello", "2", "world", "!!!" };
PrintArray(array);
Console.Write(" -> ");

PrintArray(NewArray(array));


string[] NewArray(string[] array)
{
    int index = 0;
    string[] result = new string[array.Length];

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
    StringBuilder sb = new StringBuilder();   
    foreach (var item in arr)
    {
        sb.Append(item+",");
    }

    Console.Write($"[{sb.ToString().TrimEnd(',')}]"); 
}