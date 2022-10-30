// Программа, которая принимает на вход число и выдает является ли оно четным
Console.WriteLine("Введите число");

int num = Convert.ToInt32(Console.ReadLine());

int result = num%2;

if(result==0){
    Console.WriteLine("Число четное");
}
else{
   Console.WriteLine("Число нечетное"); 
}