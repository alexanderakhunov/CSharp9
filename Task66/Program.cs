/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


int RecNum(int numA, int numB)
{
    if (numB > numA)
        return numB + RecNum(numA, numB - 1);
    return numB;
}
System.Console.WriteLine(RecNum(4,8));

