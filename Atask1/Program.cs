// Задача 2:  
// Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Здравствуйте.");
Console.WriteLine("Определим большее и меньшее числа из двух.");
Console.Write("первое число ? ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("второе число ? ");
double b = Convert.ToDouble(Console.ReadLine());
if (a == b)
{
    Console.WriteLine("числа равны");
}
else
{
    if (a < b)
    {
        Console.WriteLine("наибольшее число " + b);
        Console.WriteLine("наименьшее число " + a);
    }
    else
    {
        Console.WriteLine("наибольшее число " + a);
        Console.WriteLine("наименьшее число " + b);
    }

}
    Console.WriteLine("Всего хорошего.");
*/
//Задача 4:Напишите программу, которая принимает на вход 
//три числа и выдаёт максимальное из этих чисел.
/*
Console.WriteLine("Определим максимальное число из всех вводимых.");
Console.Write("введите количество сравниваемых чисел ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("введите первое число : "  );
double m = Convert.ToDouble(Console.ReadLine());
int current = 0;
    while (current <n-1)
{     
        Console.Write("введите следующее число : " );
        double a = Convert.ToDouble(Console.ReadLine());  
        if (a > m )
        {
            m = a;
        }
   current++; 
} 
Console.WriteLine($"максимальное число  { m }. Спасибо.");
*/
//Задача 6: Напишите программу, которая на
//вход принимает число  и выдаёт, является ли
//число чётным (делится ли оно на два без остатка).
/*
        Console.WriteLine("проверим число на чётность");
        Console.Write(" Ваше число ? ");
        int a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
        {
            Console.WriteLine($"Число  {a} чётное. Спасибо.");
        }
            else
        {
            Console.WriteLine($"Число  {a} не чётное. Спасибо.");
        }
 */
 // Задача 8: Напишите программу, которая на вход
 // принимает число (N), а на выходе показывает
 // все чётные числа от 1 до N.
         
Console.WriteLine("распечатываем чётные числа от 1 до N.");
Console.Write("введите, пожалуйста, неотрицательное число ");
int a = Convert.ToInt32(Console.ReadLine());
int current = 2;
while (current <= a)
{ 
    Console.Write($" {current} ");
    current += 2;
}

 

