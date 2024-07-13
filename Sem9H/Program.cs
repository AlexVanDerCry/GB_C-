// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// Console.Write("Введите число N: ");
// int number = Convert.ToInt32(Console.ReadLine());

// string StringOfNumbers (int start, int end)  
// {
//     if (end == start) return end.ToString();

//     return end + ", " + GetStringOfNumbers (start, end - 1);
// }

// Console.WriteLine($" '{GetStringOfNumbers(1, number)}' ");

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// Console.Write("Введите первое число: ");
// int fistNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// int GetSumOfNumbers (int fistNumber, int secondNumber) 
// {
//     if (fistNumber == secondNumber) return secondNumber;

//     return fistNumber + GetSumOfNumbers(fistNumber + 1, secondNumber);
// }

// Console.WriteLine($"Сумма цифр от чила {fistNumber} до числа {secondNumber} = {GetSumOfNumbers(fistNumber, secondNumber)}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// Не знаю как получилось, но оно работает, не понял принцип рассчета... точнее как оно сработало...

// Console.Write("Введите первое число: ");
// int fistNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());

// int Akkerman (int fistNumber, int secondNumber)
// {
//    if (fistNumber == 0)
//    {
//     return secondNumber + 1;
//    }
//    else if (secondNumber == 0)
//    {
//     return Akkerman (fistNumber - 1, 1);
//    }
//    return Akkerman (fistNumber - 1, Akkerman (fistNumber, secondNumber - 1));
// }

// Console.WriteLine($"{Akkerman(fistNumber, secondNumber)}");
