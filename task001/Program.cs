// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

//Решение. Через while.

Console.Clear();

Console.WriteLine("Введите первое число А");
int numbA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число В");
int numbB = int.Parse(Console.ReadLine());

int summa = 1;                            //Здесь решил таким способом, а через for решил по другому немного.
int i = 0;                                //В переменную summa присваиваю 1 и умножаю на numbA.
while (i < numbB)                         //Можно было сделать иначе в переменную summa присвоить numbA а в переменную i присвоить 1.
{
  summa = summa * numbA;
  i++;
}
Console.WriteLine(summa);

//Решение. Через for.

Console.WriteLine("Введите первое число А");
int numA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число В");
int numB = int.Parse(Console.ReadLine());

int suma = numA;                              //Здесь решил как описал выше.
for (int ind = 1; ind < numB; ind++)
{
  suma *= numA;
}
Console.WriteLine(suma);

//Решение. Задача через метод.

Console.WriteLine("Введите первое число А");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число В");
int numberB = int.Parse(Console.ReadLine());

int[] mas = new int[numberB];                //Переменнай numberB задаю длину массива.

MasArray(mas);
MasСycle(mas);

void MasArray(int[] numbers)                 //В данном методе я присваиваю каждому индексу переменую numberA.
{
  int mas = numbers.Length;
  for (int i = 0; i < mas; i++)
  {
    numbers[i] = numberA;
  }
}

void MasСycle(int[] number)                  //В данном методе я возвожу в степень введенное число.
{
  int sum1 = numberA;
  for (int i = 1; i < number.Length; i++)
  {
    sum1 *= numberA;
  }
  Console.WriteLine($"{String.Join(", ", sum1)}");
}