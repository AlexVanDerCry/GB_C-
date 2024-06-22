/*
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//Получаем 2 числа от пользователя
Console.Write("Укажите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

//Производим сравнение чисел с помощью If
if(firstNumber > secondNumber)
{
    Console.Write("Число " + firstNumber + " больше чем " + secondNumber);
}
else
{
    Console.Write("Число " + secondNumber + " больше чем " + firstNumber);
}
*/

/*
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//Получаем 3 числа от пользователя
Console.Write("Укажите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Укажите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

//Производим сравнение чисел с помощью If
if (firstNumber > secondNumber)
{
    if (firstNumber > thirdNumber)
    {
        Console.Write("Максимальное число: " + firstNumber);
    }
    else
    {
        Console.Write("Максимальное число: " + thirdNumber);
    }
}
else if (secondNumber > thirdNumber)
{
    Console.Write("Максимальное число: " + secondNumber);
}
else
{
    Console.Write("Максимальное число: " + thirdNumber);
}
*/

/*
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//Получаем число от пользователя
Console.Write("Укажите число для проверки, делится ли оно без остатка: ");
int number = Convert.ToInt32(Console.ReadLine());

//Проверяем число на деление без остатка с помощью % и конструкции if
if (number % 2 == 0)
{
    Console.Write("Число " + number + " делится без остатка.");
}
else
{
    Console.Write("Число " + number + " не делится без остатка.");
}
*/

/*
//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//Получаем число от пользователя
Console.Write("Укажите число: ");
int index = Convert.ToInt32(Console.ReadLine());
int number = 2;

//Используем цикл while и увеличение числа на 2 пока не дойдем до нашего числа
while(number <= index)
{
        Console.Write(number + " ");
        number +=2;
}
*/