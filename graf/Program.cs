// Задача 3: Напешите программу,которая принимает на вход число (N) и
// выдает таблицу кубов чисел от 1 до N.

void Cube(int number)
{
    int count = 0;
    if(number > 0)
    while(count <= number)
    {
        Console.WriteLine($"{count * count * count}, ");
        count +=1;
    }
    else
    {
        while(count >= number)
        {
            Console.WriteLine($"{count * count * count}, ");
            count -= 1;
        }
    }
    Console.WriteLine("\b\b.");
}
Console.Write("Введите число: ");
int USER_NUMBER = Convert.ToInt32(Console.ReadLine());
Cube(USER_NUMBER);
