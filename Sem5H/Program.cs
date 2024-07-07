/*
//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] resultArray = new int[size];

    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return resultArray;
}

int[] array = GetArray(10, 100, 999);
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ]");

    int evenNum = 0;
    int notEvenNum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            evenNum += 1;
        }
        else
        {
            notEvenNum += 1;
        }
        // evenNum = array[i] % 2 == 0 ? evenNum +=1 : 0; 
        // notEvenNum = array[i] % 2 != 0 ? notEvenNum +=1 : 0;
    }

Console.WriteLine($"Количество четных чисел: {evenNum}, количество не четных чисел: {notEvenNum}");
*/

/*
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] resultArray = new int[size];

    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return resultArray;
}

int[] array = GetArray(10, -999, 999);
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ]");

int evenIndex = 0;
int notEvenIndex = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            evenIndex += array[i];
        }
        else
        {
            notEvenIndex += array[i];
        }
    }

Console.WriteLine($"Количество четных индексов: {evenIndex}, сумма не четных индексов: {notEvenIndex}");
*/

/*
//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] resultArray = new int[size];

    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = new Random().Next(minValue, maxValue);
    }
    return resultArray;
}

int[] array = GetArray(10, -999, 999);
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ]");

int maxNumber = 0;
int minNumber = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > maxNumber)
    {
        maxNumber = array[i];
    }
    else if (array[i] < minNumber)
    {
        minNumber = array[i];
    }
}

Console.WriteLine($"Максимальное число: {maxNumber}, минимальное число: {minNumber}, разница этих чисел равна {maxNumber - minNumber}");
*/