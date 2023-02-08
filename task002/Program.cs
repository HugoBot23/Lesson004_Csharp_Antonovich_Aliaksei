// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

//Решение.

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int sum = 0;

while (number != 0)
{
  sum = sum + number % 10;
  number = number / 10;
}
Console.WriteLine(sum);

//Решение. Через метод.

Console.WriteLine("Введите число: ");
int numberB = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр = {SumNumber(numberB)}");

int SumNumber(int number)
{
  int summ = 0;

  while (numberB != 0)
  {
    summ = summ + numberB % 10;
    numberB = numberB / 10;
  }
  return summ;
}


