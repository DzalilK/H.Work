// Напешите цикл,который принимает на вход два числа (А и В)
// и возводит число А в натуральную степень В.
/* 
int A = 3;
int B = 5;

int result = 1;
for (int i = 0; i < B; i++)
{
    result *= A;
}
Console.WriteLine($"{A} в степени {B} равно {result}");
*/

//Напешите программу,которая принимает на вход число и 
//и выдает сумму цифр в числе 
//452 -> 11
//82 -> 10
//9012 -> 12
/*
int CountFors(int num_user)
{
   int fors = 0; 
   for(int count = 0; num_user != count; num_user /= 10)
    
   {
        fors += num_user % 10;
        
   }    
   return fors;
}   

        
     Console.WriteLine("Input your number: ");
int num_us = Convert.ToInt32(Console.ReadLine());

int fors_res;
if (num_us <= 0)
    fors_res = 0;

else
    fors_res = CountFors(num_us);
Console.WriteLine(fors_res);
*/
        

//Напешите программу,которая задает массив из произвольного 
//кол-ва элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

int [] Main(int args)
{
    int [] arra =new int[args];
    for(int i = 0; i < args; i++)
    {
        arra[i] = i + 1;
    }
    return arra;
}

    void PrintArray(int [] array_to_print)
    
    {
        Console.WriteLine("Your array is: ");
        for(int i = 0; i < array_to_print.Length; i++)
            Console.Write(array_to_print[i] + " ");
    }
    int size = 8;
    int [] fistArray = Main(size);
    PrintArray(fistArray);









    
    
    








