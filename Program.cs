Console.WriteLine("______________________________________________");
Console.WriteLine("Выберите задачу:\nЗадача 1\nЗадача 2\nЗадача 3");
int menu = Convert.ToInt32(Console.ReadLine());
switch (menu)
{
    case 1:
        Console.WriteLine("Задайте значения M и N. Напишите программу, которая выведет все натуральные числа промежутке от M до N. Использовать рекурсию, не использовать циклы.");
        task01();
        break;
    case 2:
        Console.WriteLine("Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
        task02();
        break;
    case 3:
        Console.WriteLine("Задайте произвольный массив. Выведете его элементы, начиная с конца.");
        task03();
        break;
}

/*Задайте значения M и N. Напишите
программу, которая выведет все натуральные числа
в промежутке от M до N. Использовать рекурсию, не
использовать циклы.*/

void GetListNatNums(int M, int N)
{
    if (M == N)
    {
        Console.Write($"{N} ");
        return;
    }

    GetListNatNums(M, N - 1);
    Console.Write($"{N} ");
}
void task01()
{
    Console.Write("Введите M: ");
    int M = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите N: ");
    int N = Convert.ToInt32(Console.ReadLine());
    GetListNatNums(M, N);
}

/*Напишите программу вычисления функции
Аккермана с помощью рекурсии. Даны два
неотрицательных числа m и n. m = 2, n = 3 -> A(m,n) = 29 */

uint A(uint n, uint m)
{
    if (n == 0)
        return m + 1;
    else if ((n != 0) && (m == 0))
        return A(n - 1, 1);
    else
        return A(n - 1, A(n, m - 1));
}
void task02()
{
    Console.Write("Введите M: ");
    uint AM = Convert.ToUInt32(Console.ReadLine());
    Console.Write("Введите N: ");
    uint AN = Convert.ToUInt32(Console.ReadLine());
    Console.Write(A(AM, AN));
}

/*Задайте произвольный массив. Выведете
его элементы, начиная с конца.*/

static int[] ArrReverse(int[] array, int j, int i)
{
    if (i < j)
    {
        return array;
    }
    int temp = array[j];
    array[j] = array[i];
    array[i] = temp;
    return ArrReverse(array, j + 1, i - 1);
}

static void PrintArray(int[] array)
{
    foreach (int num in array)
    {
        Console.Write($"{num} ");
    }
    Console.WriteLine();
    return;
}

void task03()
{
    int size = 5;
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Random rnd = new Random();
        array[i] = rnd.Next(1, 50);
    }
    PrintArray(array);
    PrintArray(ArrReverse(array, 0, size - 1));
}