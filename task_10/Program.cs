Console.WriteLine("Введите Ваше трёзначное число");
int v = Convert.ToInt32(Console.ReadLine());

int central = (v%100)/10;

Console.WriteLine($"{central} - вторая цифра Вашего числа");