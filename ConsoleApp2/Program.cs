Console.WriteLine("Введите два числа для нахождения суммы");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
static int Sum(int a, int b)
{
    return a + b;
}
int result = Sum(num1, num2);
Console.WriteLine($"Сумма чисел {num1} и {num2} равна {result}");

Console.WriteLine("Введите радиус окружности для нахождения её площади");
double radius = Convert.ToDouble(Console.ReadLine());
static double CalculateCircleArea(double radius)
{
    return Math.PI * radius * radius;
}
double area = CalculateCircleArea(radius);
Console.WriteLine($"Площадь окружности с радиусом {radius} равна {area}");

Console.WriteLine("Введите строку");
string inputString = Console.ReadLine();
static int CalculateStringLength(string input)
{
    return input.Length;
}
int length = CalculateStringLength(inputString);
Console.WriteLine($"Длина строки '{inputString}' равна {length}");

Console.WriteLine("Введите массив целых чисел");
int[] celmas = new int[5];
for (int i = 0; i < 5; i++)
{
    celmas[i] = Convert.ToInt32(Console.ReadLine());
}
int maximumvalue(int[] arr)
{
    int maxValue = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxValue)
        {
            maxValue = arr[i];
        }
    }
    return maxValue;
}
Console.WriteLine("Вывод: " + maximumvalue(celmas));

Console.WriteLine("Введите число");
int inputNumber = Convert.ToInt32(Console.ReadLine());
static long CalculateFactorial(int number)
{
    if (number == 0)
    {
        return 1;
    }
    long factorial = 1;
    for (int i = 1; i <= number; i++)
    {
        factorial *= i;
    }
    return factorial;
}
long res = CalculateFactorial(inputNumber);
Console.WriteLine($"Факториал числа {inputNumber} равен {res}");

Console.WriteLine("Введите слово, чтобы узнать, является ли оно палиндромом");
string inputStr = Console.ReadLine();
bool ispoly(string i)
{
    string reverse = new string(i.ToCharArray().Reverse().ToArray());
    if (i.Equals(reverse))
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.WriteLine(ispoly(inputStr));

Console.WriteLine("Введите первый массив");
int[] ar1 = new int[5];
for (int i = 0; i < 5; i++)
{
    ar1[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите второй массив");
int[] ar2 = new int[5];
for (int i = 0; i < 5; i++)
{
    ar2[i] = Convert.ToInt32(Console.ReadLine());
}
string ar3(int[] x, int[] y)
{
    return string.Join(", ", x.Concat(y).ToArray());
}
Console.WriteLine("Новый массив: " + ar3(ar1, ar2));

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
bool isprime(int a)
{
    if (a <= 1)
    {
        return false;
    }
    for (int i = 2; i <= Math.Sqrt(a); i++)
    {
        if (a % i == 0)
        {
            return false;
        }
    }
    return true;
}
Console.WriteLine(isprime(num));

Console.WriteLine("Введите строку");
string inpString=Console.ReadLine();
static string ReverseString(string inpString)
{
    char[] charArray = inpString.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}
string reversedString = ReverseString(inputString);
Console.WriteLine($"Строка в обратном порядке: {reversedString}");

Console.WriteLine("Введите двумерный массив");
int[,]  array1= new int[3, 3];
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        array1[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
int arrsum(int[,] z)
{
    {
        int sum = 0;
        foreach (int num in z)
        {
            sum += num;
        }
        return sum;
    }
}
Console.WriteLine(arrsum(array1));