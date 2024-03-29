﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int GetNumber(string message)
{
    int result = 0;
    
    while (true)
    {
        Console.WriteLine(message);
    
        if(int.TryParse(Console.ReadLine(), out result) && result >= 0)
        {
            break;
        }
        else 
        {
            Console.WriteLine("Ввели не натуральное число. Повторите ввод");
        }
    }
    return result;
}

int GetAckermann (int num1, int num2)
{
    
    if (num1 == 0) return num2 + 1;
    else if (num2 == 0) return GetAckermann(num1 - 1, 1);
    else return GetAckermann(num1 - 1, GetAckermann(num1, num2 - 1));
}

int m = GetNumber("Введите M ");
int n = GetNumber("Введите N ");
Console.WriteLine();
Console.WriteLine(GetAckermann(m,n));