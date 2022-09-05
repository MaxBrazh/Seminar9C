﻿/* Задача 64. Задайте значения M и N.
Напишите программу, которая выведет все натуральные
числа в промежутке от M до N по убыванию.
M = 1; N = 5. -> ""5,4,3,2,1""
M = 4; N = 8. -> ""8,7,6,5,4""  */

using static System.Console;
Clear();

WriteLine($"\"\"{GetStringNumbersRec(Input("M"), Input("N"))}\"\"");


int Input(string text)
{
    WriteLine($"Введите номер {text}: ");
    int number = int.Parse(ReadLine()!);
    return number;
}

string GetStringNumbersRec(int a, int b)
{
    if (a == b) return $"{b}";
    if (a > b) return $"{a}," + GetStringNumbersRec(a - 1, b);
    return $"{b}," + GetStringNumbersRec(b - 1, a);
}