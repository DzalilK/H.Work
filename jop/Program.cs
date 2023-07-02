// Напешите программу,которая принимает на вход трехзначное число
// и на выходе показывает вторую цифру этого числа 
/*
Console.WriteLine("Input number from 100 till 999");
int num = Convert.ToInt32(Console.ReadLine());
if((num > 99) && (num < 1000))
 {
     Console.WriteLine(num % 100 / 10);
 }
*/


// Напешите программу,которая выводит третью цифру заданого числа
// или сообщает,что третьй цифры нет 

/*
int number = new Random().Next(10,99999);
Console.WriteLine("number" + number);
void Num(int a)
{
    if((a >= 10) && (a <= 99))
    {
        Console.WriteLine("Нет третей цифры");
    }
    if((a >= 100) && (a <= 999))
    {
        Console.WriteLine(a % 10);
    }
    if((a > 999) && (a < 10000))
    {
        Console.WriteLine((a % 100) / 10);
    }
    if((a >= 1000) && (a < 99999))
    {
        Console.WriteLine((a % 1000) / 100);
    }
}
Num(number);
*/

// Напешите программу,которая принимает на вход цифру,
// обозначающея день недели,и проверяет,является ли этот день выходным

Console.WriteLine("Input day");
int day = Convert.ToInt32(Console.ReadLine());
if((day > 0) && (day < 7))
{
    Console.WriteLine("weekday");
}
if((day > 5) && (day < 8))
{
    Console.WriteLine("weekend");
}
if((day < 1) || (day > 7))
{
    Console.WriteLine("error");
}
