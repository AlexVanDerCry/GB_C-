/*
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100 || number >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число. Повторите попытку, я уверен, у вас это получится");
}
else
{
    Console.WriteLine($"Вы ввели число {number}");
    int secondNumber = number / 10 % 10;
    Console.WriteLine($"Произошла магия, вторая цифра твоего чила это - {secondNumber}");
}
*/

/*
//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//Не понял сразу как вытащить третью цифру из чисел выше 999, переписал жатлонное решение и понял как оно работает.

int Prompt (string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int GetThirdRank (int number)
{
    while(number > 999)
    {
        number /= 10;
    }
    return number % 10;
}

bool ValidateNumber (int number)
{
    if (number < 100)
    {
        Console.WriteLine ("Третьей цифры нет");
        return false;
    } 
    return true;
}

int number = Prompt ("Введите число > ");
if (ValidateNumber(number))
{
    Console.WriteLine (GetThirdRank(number));
}
*/

/*
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//Эту задачу писал самостоятельно, опираясь на эталонное решение 2 задачи.
int Prompt (string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool ValidateNumber (int number)
{
    if (number > 7 || number <= 0)
    {
        Console.WriteLine ("Нет такого дня недели.");
        return false;
    } 
    return true;
}


int number = Prompt ("Введите число > ");
if (ValidateNumber(number))
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Да, этот день недели - выходной!");
    }
    else
    {
        Console.WriteLine ("Это будни!");
    }
}
*/