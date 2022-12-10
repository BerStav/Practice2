// Программа, которая на вход принимает трёхзначное число и на выходе показывает вторую цифру этого числа.


int SecondNumber(int x)
    {
        int a = x / 100;
        int b = x / 10 - a * 10;
        int c = x - b * 10 - a * 100;   
        return b;
    }   

Console.Write("Please, enter the three-digit number: ");

int TDNumber = int.Parse(Console.ReadLine());

int FindNumber = SecondNumber(TDNumber);

Console.Write("The second number of three-digital number is: ");
Console.Write(FindNumber);