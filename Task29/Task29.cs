//Напишите метод, который задаёт массив из N элементов и выводит их на экран.
int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] CreateArray(int size, int min, int max)
{
    int[] array = new int [size];
    Random RandomNum = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = RandomNum.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + " ");
    } 
    Console.Write(array[array.Length - 1]);
}

int N = Input("Введите длину массива: ");
int min = Input("Введите минимальное значение массива: ");
int max = Input("Введите максимальное значение массива: ");
int[] array = CreateArray(N, min, max);
PrintArray(array);
