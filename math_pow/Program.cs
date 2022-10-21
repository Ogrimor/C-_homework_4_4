int getValue(string msg)
{
    Console.WriteLine(msg);
    int a = int.Parse(Console.ReadLine());
    return a;
}
int getDegree(int a, int b)
{
    int degree = a;    
    for (int i = 1; i < b; i++)
    {
        degree *= a;
    }
    return degree;    
}

int baseOfDegree = getValue("Введите основание степени: ");
int degreeValue = getValue("Введите значение степени: ");
if (degreeValue > 0) Console.WriteLine(getDegree(baseOfDegree, degreeValue));
else Console.WriteLine("Error");