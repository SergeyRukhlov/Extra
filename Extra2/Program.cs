// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
//что третьей цифры нет.

Console.Write("Введите трехзначное число: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
string anyNumberText = Convert.ToString(anyNumber);
if (anyNumberText.Length > 2)
{
    Console.WriteLine(" Третья цифра этого числа :" + anyNumberText[2]);
}
else
{
    Console.WriteLine(" Третьей цифры этого числа нет ");
}
