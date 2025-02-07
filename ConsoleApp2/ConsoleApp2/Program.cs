using System;
namespace Calculator;

class Program
{
    static void Main()
    {
        int firstNumber = 15;
        int secondNumber = 5;
        int totalSum = AddNumbers(firstNumber, secondNumber);

        Console.WriteLine($"Сумма: {totalSum}");
        Console.ReadLine();
    }

    static int AddNumbers(int x, int y)
    {
        return x + y;
    }
}
