string[] array = new string[] {"Hello", "2", "world", ":-)"};
int Array = 0;
for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3) Array++;
}

string[] newArray = new string[Array];
int idx = 0;

for (int i = 0; i <= array.Length - 1; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[idx] = array[i];
        idx++;
    }
}

PrintArray(array);
Console.Write("Массив до 3-х знаков: ");
PrintArray(newArray);

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"“{array[i]}“,");
    }
    Console.Write("]");
}