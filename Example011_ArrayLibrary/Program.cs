void FillArray(int[] collection)
{
    int legth = collection.Length;
    int index = 0;
    while (index < legth)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
    // return int[] collection;
}

void PrintArray(int[] anothercoll)
{
    int count = anothercoll.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(anothercoll[position] + " ");
        position++;
    }

}

int Indexof(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        { position = index; break; }
        index++;
    }
    return position;
}

int[] array = new int[10];
FillArray(array);
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
} // Оказалось, что метод FillArray  не возвращает ничего, но меняет массив!!
PrintArray(array);
Console.WriteLine();

//int pos = Indexof(FillArray(array), 8);
int pos = Indexof(array, 8);

Console.WriteLine("Index of element: " + pos);







