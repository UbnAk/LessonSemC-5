// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76


double[] CreatArray(int Len) // создаем массив с len длиной 
{
    double [] array = new double[Len];
    for (int i = 0; i < array.Length; i++)
    {

        array[i] = Math.Round(new Random().NextDouble() * 10, 2);// присваиваем рандомное вещественное значение
    }
    return array;
}


void PrintArray(double [] array) // печатаем массив функция
{
System.Console.Write("[");
for (int i = 0; i < array.Length -1; i++)
{
    System.Console.Write(array[i] + "; ");
}
System.Console.WriteLine(array[array.Length -1] + "]");
}

int ReadInt (string arg) // функция ввода числа
{
    System.Console.WriteLine($"Введите {arg} ");
    return int.Parse(System.Console.ReadLine());
}
int Len = ReadInt("Введите длину массива: ");// запрашиваем длину массива через функцию
double[] array = CreatArray(Len);// создаем массив ранее записанной функции
PrintArray(array); //  выводим массив


double MaxValue(double[]array)// поиск максимальноего элемента
{
    double Max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>Max) Max = array[i];
    }
    return Max;
}

double MinValue(double[]array) // поиск минимального элемента
{
    double Min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]<Min) Min = array[i];
    }
    return Min;
}

double Diff(double [] array) //функция поиска разницы значений в массиве.
{
    double diffValue = MaxValue(array) - MinValue(array);
    return diffValue;
} 

System.Console.WriteLine($"Максимальное значение элементов массива  = {MaxValue(array)}");
System.Console.WriteLine($"Минимальное значение элементов массива = {MinValue(array)}");
System.Console.WriteLine($"Разница между {MaxValue(array)} и {MinValue(array)} = {Diff(array)}");