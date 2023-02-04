// Задать номер четверти, показать диапозоны для возможных координат

Console.WriteLine("Введите номер четверти (I, II, III, IV): ");
string Number = Console.ReadLine();

if (Number == "I")
{
    Console.WriteLine(" В четверти " + Number + " диапозон координат (x>0; y>0) ");
}
else if (Number == "II")
{
   Console.WriteLine(" В четверти " + Number +  " диапозон координат (x<0; y>0)");
}
else if (Number == "III")
{
   Console.WriteLine(" В четверти " + Number +  " диапозон координат (x<0; y<0)");
}
else if (Number == "IV")
{
   Console.WriteLine(" В четверти " + Number +  " диапозон координат (x>0; y<0)");
}
else
{
     Console.WriteLine("Неверно введен номер четверти, используйте (I, II, III, IV)");
}
