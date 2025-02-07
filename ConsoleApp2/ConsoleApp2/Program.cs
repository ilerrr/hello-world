using System;
namespace Calculator;

class Program
{
    static void Main()
    {
        int firstNumber = 10;
        int secondNumber = 15;
        int totalSum = AddNumbers(firstNumber, secondNumber);

        Console.WriteLine($"Сумма: {totalSum}");
        Console.ReadLine();
    }

    static int AddNumbers(int x, int y)
    {
        return x + y;
    }
}
