// По двум заданным числам проверять является ли один квадратом второго 

Console.WriteLine("Введите первое число: ");
int Number1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите второе число: ");
int Number2 = int.Parse(Console.ReadLine() ?? "0");

if (Number1 == Number2 * Number2)
{
     Console.WriteLine(" Первое число является квадратом второго числа ");
}
else if (Number2 == Number1 * Number1)
{
    Console.WriteLine(" Второе число является квадратом первого числа ");
}
else
{
    Console.WriteLine(" Данные числа не являются квадратами друг друга ");
}
