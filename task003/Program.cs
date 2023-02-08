// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

//Решение.

Console.Clear();

int[] mas = new int[8];

MasNumber(mas);
MasEnumeration(mas);
PrintMas(mas);

void MasNumber(int[] number) //В данном методе создаю рандомный массив.
{
  int mas1 = number.Length;
  int i = 0;
  while (i < mas1)
  {
    number[i] = new Random().Next(1, 100);
    i++;
  }
  Console.ForegroundColor = ConsoleColor.Yellow;
  Console.WriteLine("Не отсортированный массив"); // Вывел в консольк что-бы видить разницу в массивах.
  Console.WriteLine($"{String.Join(", ", number)}");
}

void MasEnumeration(int[] numb) //В данном методе сортирую созданный массив.
{
  int temp;
  int i = 0;
  while (i < numb.Length)
  {
    int j = i + 1;
    while (j < numb.Length)
    {
      if (numb[i] > numb[j])
      {
        temp = numb[i];
        numb[i] = numb[j];
        numb[j] = temp;
      }
      j++;
    }
    i++;
  }
}
void PrintMas(int[] numbers) // В этом методе вывожу в консоль отсортированный массив.
{
  Console.ForegroundColor = ConsoleColor.Green;
  Console.WriteLine("Вывод отсортированного массива");
  Console.WriteLine($"{String.Join(", ", numbers)}");
}
Console.ForegroundColor = ConsoleColor.White;