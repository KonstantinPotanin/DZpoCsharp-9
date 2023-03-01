// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetNumber(string message)
{
    int result = 0;
    
    while (true)
    {
        Console.WriteLine(message);
    
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
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

int GetSumNumbers(int num1, int num2)
{
    
    if (num1 == num2) return num1;
    else
    { 
        return  num1 + GetSumNumbers(num1+1, num2);
    }
}

int m = GetNumber("Введите M ");
int n = GetNumber("Введите N ");
Console.WriteLine();
Console.WriteLine($"Сумма равна {GetSumNumbers(m,n)}");
