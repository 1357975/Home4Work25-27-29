void Zadacha25()
//Задача 25: Используя определение степени числа, напишите цикл, 
//который принимает на вход два натуральных числа (A и B) и 
//возводит число A в степень B. 3, 5 -> 243 (3⁵) и 2, 4 -> 16
{
    Console.WriteLine("Задача 25.");
    Random rand = new Random();
    int A = rand.Next(1, 11);
    Console.Write($"A = {A} ");
    int B = rand.Next(1, 11);
    Console.WriteLine($"B = {B} ");

    int i = 1;
    int result = 1;

    while (i <= B)
    {
        result = result*A;
        i++;
    }
    Console.WriteLine($"Ответ: A^B = {A}^{B} = {result}");
}

void Zadacha27()
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12 

{
    Console.WriteLine("Задача 27.");
    Random rand = new Random();
    int number = rand.Next(1, 10000);
    Console.WriteLine($"Число: {number} ");
    Console.Write($"Ответ: сумма цифр в числе {number} = ");

    int result = 0;

    while (number > 0)
    {
        result = result + number % 10;
        number = number / 10;
    }
    Console.WriteLine(result);
}

void FillArray(int[] nums)
{
    Random rand = new Random();
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
        nums[i] = rand.Next(-99, 100);
    }
}

void PrintArray(int[] nums)
{
    int size = nums.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write(nums[i] + " ");
    }
    Console.WriteLine();
}


void Zadacha29()
//Задача 29: Напишите программу, которая задаёт массив из 8 случайных целых чисел и 
//выводит отсортированный по модулю массив.
//-2, 1, -7, 5, 19 -> [1, -2, 5, -7, 19]
//6, 1, -33 -> [1, 6, -33]

{
    Console.WriteLine("Задача 29.");
    Console.Write("Случайный массив из 8 элементов от -99 до 99:\t ");
    int size = 8;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);

    for (int i = 0; i < size - 1; i++)
    {
        for (int j = 0; j < size - 1 - i; j++)
        {
            if (Math.Abs(numbers[j]) > Math.Abs(numbers[j + 1]))
            {
                int t = numbers[j];
                numbers[j] = numbers[j + 1];
                numbers[j + 1] = t;
            }
        }
    }
    Console.Write("Ответ: отсортированный по модулю массив: ");
    PrintArray(numbers);

}

Zadacha25();
Zadacha27();
Zadacha29();