Console.WriteLine("Введите Ваше число");
int v = Convert.ToInt32(Console.ReadLine());

if (v == 1)
{
    Console.WriteLine("Нет, это понедельник.");
}
else if (v == 2)
{
    Console.WriteLine("Нет, это вторник.");
}
else if (v == 3)
{
    Console.WriteLine("Нет, это среда.");
}
else if (v == 4)
{
    Console.WriteLine("Нет, это четверн.");
}
else if (v == 5)
{
    Console.WriteLine("Нет, это пятница.");
}
else if (v == 6)
{
    Console.WriteLine("Да, это суббота.");
}
else if (v == 7)
{
    Console.WriteLine("Да, это воскресенье.");
}
else
{
    Console.WriteLine("Нет, это не день недели.");
}