// 1)Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
internal class Program
{
    private static void Main(string[] args)
    {
        
        int numberA = ReadInt("Введите число A: ");
        int numberB = ReadInt("Введите число B: ");
        ToDegree(numberA, numberB);


        // Функция возведения в степень
        void ToDegree(int a, int b)
        {
            int result = 1;
            for (int i = 1; i <= b; i++)
            {
                result = result * a;
            }
            Console.WriteLine(result);
        }

        // Функция ввода
        int ReadInt(string message)
        {
            Console.WriteLine(message);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}*/
// 2)Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*int number = ReadInt("Введите число: ");

int len = NumberLen(number);
SumNumbers(number, len);

// Функция подсчета цифр в числе
int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

// Функция вывода суммы цифр в числе
void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"Сумма цифр = {sum}");
}

// Функция ввода
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}*/
//3)Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
/*
internal class Program
{
    private static void Main(string[] args)
    {
        int lenArray = ReadInt("Введите длинну массива: ");

        int[] randomArray = new int[lenArray];
        for (int i = 0; i < randomArray.Length; i++)
        {
            randomArray[i] = new Random().Next(0, 100);
            Console.Write($"[{randomArray[i]}]  " );
        }


        // Функция ввода
        int ReadInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
*/