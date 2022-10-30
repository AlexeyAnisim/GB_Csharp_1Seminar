// На вход принимает 2 числа и выдает большее и меньшее
Console.WriteLine("Введите два любых числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1>num2){
    Console.WriteLine($"Большее число: {num1}, Меньшее число: {num2}");
}
else
{
   Console.WriteLine($"Большее число: {num2}, Меньшее число: {num1}"); 
}