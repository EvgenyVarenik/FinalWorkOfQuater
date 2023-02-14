
string [] array = new string [4] {"hello", "2h8", "world", ":)"};
Console.WriteLine(string.Join(", ", array));

int NewArraySize (string [] array)
{
    int count = 0;
    for (int i=0;i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;  
}

void NewMassive (string [] array, string [] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[count]=array[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int size = NewArraySize (array);
string [] array2 = new string [size];
NewMassive (array, array2);
PrintArray(array2); 