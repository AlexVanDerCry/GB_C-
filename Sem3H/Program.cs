/*
//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int Prompt (string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool isItNumRight (int number)
{
    if (number >= 10000 && number < 99999)
    {
                return true;
    }
    else
    {
        Console.WriteLine("Ошибка, введите 5-ти значное число без букв и символов");
        return false;
    }

}

int num = Prompt("Введите 5-ти значное число для проверки его на палиндром: ");
if (isItNumRight(num))
{
    if(num  / 10000 == num % 10 && num / 1000 % 10 == num /10 % 10)
    {
        Console.WriteLine($"Число {num} является полиндромом!");
    }
    else
    {
        Console.WriteLine($"Число {num} не полиндром! :( )");
    }
}
*/

/*
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
var stringNumber = Console.ReadLine();

bool isItNum = int.TryParse(stringNumber, out int num);

if (isItNum && num > 99)
{
    Console.Write($"Третья цифра числа {stringNumber} - {stringNumber[2]}");
}
else if (isItNum && num < 99)
{
    Console.Write($"В числе {stringNumber} - нет второй цифры.");
}
else
{
    Console.WriteLine("Ошибка! В строчке присутсвуют и другие символы");
}
*/
 /*
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int Prompt (string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int number = Prompt("Введите число дня недели: ");

if (number == 6 || number == 7) Console.WriteLine($"День недели {number} - выходной");
else if (number != 6 || number != 7) Console.WriteLine($"День недели {number} - рабочий день");
else Console.WriteLine("Что-то пошло не так...");
*/

/*
Console.Write("Введите число дня недели: ");
var stringNumber = Console.ReadLine();

bool isItNum = int.TryParse(stringNumber, out int num);

if (isItNum && num == 6 && num < 8 || isItNum && num == 7 && num < 8 ) Console.WriteLine($"День недели {stringNumber} - выходной");
else if (isItNum && num != 6 && num < 8 || isItNum && num != 7 && num < 8 ) Console.WriteLine($"День недели {stringNumber} - рабочий день");
else Console.WriteLine("Что-то пошло не так...");
*/