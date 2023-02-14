/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/


int FuncAkkerm(int numA, int numB)
{
    if (numA == 0)
    {
        return numB + 1;
    }
    if (numA > 0 && numB == 0)
    {
        return FuncAkkerm(numA - 1, 1);
    }
    if (numA > 0 && numB > 0)
    {
        return FuncAkkerm(numA - 1 , FuncAkkerm(numA, numB - 1));
    }
    return 0;
}

System.Console.WriteLine(FuncAkkerm(2, 3));