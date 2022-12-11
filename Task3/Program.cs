// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли день выходным.

Console.WriteLine("Please, enter the week's day number between 1 to 7: ");

int EntDayNumb = int.Parse(Console.ReadLine());

if (EntDayNumb == 6 || EntDayNumb == 7)
    {
        Console.WriteLine("Yes! It's a holiday!");
    }
else
    {
        Console.WriteLine("No, it's not a holiday!");
    }