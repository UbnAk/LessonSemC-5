// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

int [] CreateArray(int Lenght, int min, int max)
{
    int [] array = new int [Lenght];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min,max);
    }
    return array;
}

void PrintArray(int [] numbers)
{
System.Console.Write("[");
for (int i = 0; i < numbers.Length -1; i++)
{
    System.Console.Write(numbers[i] + "; ");
}
System.Console.WriteLine(numbers[numbers.Length -1] + "]");
}


int ReadInt (string arg)
{
    System.Console.WriteLine($"Введите {arg} ");
    return int.Parse(System.Console.ReadLine());
}

int Lenght = ReadInt("Введите длину массива: ");
int min = ReadInt("Введите минимальное значение массива, оно должно быть трехзначным: ");
int max = ReadInt("Введите максимальное значение массива, оно должно быть трехзначным: ");
int [] numbers = CreateArray(Lenght, min, max);
PrintArray(numbers);

void Task1(int [] numbers)
{
int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i]%2 == 0)
    {
        count++;
    }
}
System.Console.WriteLine(count);
}

Task1(numbers);
