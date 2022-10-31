string[] array = new string [7] {"Hello", "2", "world", "-2", "1234", "1567", "computer_science"};
string[] arrayFinal = new string[array.Length];


void PrintArray(string[] array)
{
for (int i = 0; i < array.Length; i++)
{
        Console.Write($"{array[i] + "  "} ");
}
    Console.WriteLine();
}


void NewArray(string[] array, string[] arrayFinal)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        arrayFinal[count] = array[i];
        count++;
        }
    }
}
Console.Write($"Задан массив: ");
PrintArray(array);
Console.WriteLine();

Console.Write($"Новый массив: ");
NewArray(array, arrayFinal);
PrintArray(arrayFinal);