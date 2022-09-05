/* Задача 66: Задайте значения M и N.
 Напишите программу, которая найдёт сумму натуральных 
 элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30   */

using static System.Console;
Clear();

int m = InputNumbers("Введите значение M: ");
int n = InputNumbers("Введите значение N: ");
int digit = m;

if (m > n)
{
    m = n;
    n = digit;
}

PrintSumm(m, n, digit = 0);

void PrintSumm(int m, int n, int summ)
{
    summ = summ + n;
    if (n <= m)
    {
        Write($"Сумма натуральных элементов в промежутке от M до N = {summ} ");
        return;
    }
    PrintSumm(m, n - 1, summ);
}

int InputNumbers(string input)
{
    Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}