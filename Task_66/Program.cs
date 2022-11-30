// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = InputInt("Введите M: ");
int N = InputInt("Введите N: ");
Console.WriteLine($"Сумма элементов от {M} до {N} = {CountNaturalSum(M, N)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int CountNaturalSum(int M, int N)
{
    if (M == N)
        return N;
    return N + CountNaturalSum(M, N - 1);
}