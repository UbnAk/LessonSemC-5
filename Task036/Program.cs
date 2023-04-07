﻿// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0




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
int min = ReadInt("Введите минимальное значение массива: ");
int max = ReadInt("Введите максимальное значение массива: ");
int [] numbers = CreateArray(Lenght, min, max);
PrintArray(numbers);


void Task1(int [] numbers)
{
int result = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (i%2 ==1)
    {
        result += numbers[i];
    }
}
System.Console.WriteLine($"Сумма элементов стоящих на нечетных индексах = {result}");
}

Task1(numbers);