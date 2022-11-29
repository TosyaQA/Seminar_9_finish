// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int N = InputInt("Введите положительное число: ");
int M = 1;
if (N < 1) {
    Console.WriteLine($"Введите ПОЛОЖИТЕЛЬНОЕ число!");
} else {

    Console.WriteLine(NaturalNumber(N, M));
}

int NaturalNumber(int N, int M)
{
    if (N == M)
        return N;
    else
        Console.Write($"{NaturalNumber(N, M + 1)}, ");
    return M;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}