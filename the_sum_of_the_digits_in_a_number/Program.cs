int [] getIntArrey (string s)
{
    
    int[] arr = new int[s.Length];//     
    for (int i = 0; i < s.Length; i++)
    {
        arr[i] = Convert.ToInt32(s.Substring(i, 1));
    }
    return arr;
}

int getSumDigit(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum = sum + arr[i];
    }
    return sum;
}
Console.WriteLine("Введите желаемое число: ");
string s = Console.ReadLine();
char[] removeMinus = {'-'};
string s1 = s.TrimStart(removeMinus);
int[] arr = getIntArrey(s1);
Console.WriteLine(getSumDigit(arr));