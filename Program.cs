// Написать программу вычисления произведения чисел от 1 до N

Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
int sum = 1;

for (int i = 2; i <= num; i++)
{
   
    sum = sum * i;

}
   Console.WriteLine(sum);


