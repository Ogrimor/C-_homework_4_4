int getValue(string msg)
{
    Console.WriteLine(msg);
    int a = int.Parse(Console.ReadLine());
    return a;
}

int[] createArr(int a, int b, int c)
{
    int[] arr = new int[a];
    Random rand = new Random();
        for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(b , c + 1);
    }
    return arr;
}

void printArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i == arr.Length-1)
        {
            Console.Write(arr[i]);
            break;
        }
        Console.Write($"{arr[i]},");
    }
    Console.Write("]");
}
int arreyLength = getValue("Введите желаемую длинну массива");
int minValue = getValue("Введите минимальное значение элемента в массиве");
int maxValue = getValue("Введите максимальное значение элемента массива");
int[] arrey = createArr(arreyLength, minValue, maxValue);
printArr(arrey);