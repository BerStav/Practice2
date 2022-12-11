// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Please, enter the number: ");

int Number = int.Parse(Console.ReadLine());

string NumberToText = Convert.ToString(Number);
if (NumberToText.Length > 2)
    {
    Console.WriteLine("The third number is : " + NumberToText[2]);
    }
else
    {
    Console.WriteLine("Don't find the third number");
    }