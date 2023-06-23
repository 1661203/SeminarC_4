/*Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.


void MetFindSum (int a)
{
    int sum = 0;
    for (int current =1; current<=a; current++)
    {
        sum+=current;       //sum=sum+current
    }
    Console.WriteLine ($"Summ of elements from 1 to {a} is {sum}");
}

Console.WriteLine("Input your number:");
int user_num = Convert.ToInt32(Console.ReadLine());

if (user_num >= 1)
{
    MetFindSum (user_num);
}
else
Console.WriteLine ("Impossible val!");
*/

/*Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

int CountOfDigits (int number)
{
    int countDigit = 1;
    while (number >= 10)
    {
        number=number/10;
        countDigit++;
    }
    return countDigit;
}

Console.WriteLine("Input number: ");
int user_num=Convert.ToInt32(Console.ReadLine());
int count;

if (user_num >=0)
{
    count = CountOfDigits(user_num);
}
else
{
    count = CountOfDigits (user_num*(-1));
}
Console.WriteLine (count);*/

/*Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

void MultipleFinder (int n)
{
    int multi = 1;
    for (int cur =1; cur<= n; cur++)
    {
        multi*=cur;  // multi = multi*cur
    }
    Console.WriteLine($"{n} -> {multi}");
}

Console.WriteLine ("Enter number: ");
int number = Convert.ToInt32 (Console.ReadLine());

if (number <= 0)
{
    while (number <= 0)
    {
        Console.WriteLine ("Enter POSITIVE number: ");
        number = Convert.ToInt32 (Console.ReadLine());
    }
}
MultipleFinder (number);
*/

/*Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]

int [] CreateNewArray (int size, int min, int max)
{
    int [] array = new int [size];
    for (int i=0; i<size; i++)
    array [i] = new Random().Next (min, max+1);

    return array;
}

void ShowArray (int [] array)
{
    for (int i=0; i<array.Length; i++)
    Console.Write (array [i]+ " ");
}

Console.WriteLine ("Enter count of elements: ");
int countOfElements = Convert.ToInt32(Console.ReadLine());
int minVal = 0;
int maxVal = 1;

int [] array1 = CreateNewArray (countOfElements, minVal, maxVal);
ShowArray(array1);
*/


// Домашнее задание.

/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

Console.Write("Enter number A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number B: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = 1;
if (b<1)
Console.Write("Number B is not natural number!");
else
{
while (b!=0)
{
c = c * a;
b = b-1;
}
Console.Write($"{c}");
}*/

/*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Sum (int number)
{
    int count = Convert.ToString(number).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
      advance = number - number % 10;
      result = result + (number - advance);
      number = number / 10;
    }
   return result;
  }

Console.Write("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());
int sumNumber = Sum(number);
Console.WriteLine("the sum of the digits in the number is " + sumNumber);
*/

/*Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] numbers = new int[8];
Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(0, 11);
    Console.Write(" " + Method (i) + " ");
 }
Console.Write("]");

int Method (int a)
{
    return numbers[a];
}*/