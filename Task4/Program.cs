// Программа вывода четных чисел от 1 до N
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

for(int num1 = 1; num1<=num; num1 ++)
{
    if(num1%2 == 0)
    {
        Console.WriteLine(num1 + " ");
    }
}
if(num == 1)
{
    Console.WriteLine("нет четных чисел");
}