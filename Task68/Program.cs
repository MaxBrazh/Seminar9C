/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 29   */

using static System.Console;
Clear();

int m = InputNumbers("Введите число m: ");
int n = InputNumbers("Введите число n: ");

int funcAkkerman = Akk(m, n);

Write($"Функция Аккермана = {funcAkkerman} ");

int Akk(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Akk(m - 1, 1);
    else return Akk(m - 1, Akk(m, n - 1));
}

int InputNumbers(string input)
{
    Write(input);
    int output = Convert.ToInt32(ReadLine());
    return output;
}