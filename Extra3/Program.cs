// Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите цифру, обозначающую день недели, где пн-1, вт-2, ср-3, чт-4, пт-5, сб-6, вс-7: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void CheckingTheDayOfTheWeek(int dayNumber)
{
    if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("Это выходной, пора бахнуть пива");
    }
    else if (dayNumber < 1 || dayNumber > 7)
    {
        Console.WriteLine("Это вообще не день недели");
    }
    else Console.WriteLine("Это не выходной, иди работай");
}

CheckingTheDayOfTheWeek(dayNumber);
