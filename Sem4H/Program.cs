/*
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int PowNumbers(int numberA, int numberB)
{
    int i = 1;
    int numberPow = numberA;
    while (i < numberB)
    {
        numberA *= numberPow;
        i++;
    }
    return numberA;
}

int numberA = Prompt("Укажите число: ");
int numberB = Prompt("Укажите в какую степень возводим: ");

Console.WriteLine($"Число {numberA}, возведенное в степень {numberB} = {PowNumbers(numberA, numberB)}");
*/

/*
//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int NumSum(int number)
{
    int result = 0;
    while (number != 0)
    {
        result += number % 10;
        number = number / 10;
    }
    return result;
}

int number = Prompt("Укажите число: ");

Console.WriteLine($"Суммам чисел в цифре {number} равна {NumSum(number)}");
*/

/*
//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int size = Prompt("Укажите размер создаваемого массива: ");
int[] array = new int[size];
Random rand = new Random();
for (int i = 0; i < size; i++) {array[i] = rand.Next(1000);}

Console.WriteLine($"Массив: [ {String.Join("; ",array)} ]");
*/