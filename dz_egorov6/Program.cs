Console.WriteLine("Введите показания температуры");
int temperature = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("[1]-Из цельсия в фаренгейты");
Console.WriteLine("[2]-Из фаренгейта в цельсий");
int type = Convert.ToInt32(Console.ReadLine());
double result;
switch (type)
{
      case 1:
        result = (temperature * 9.0) / 5.0 + 32;
        break;
      case 2:
        result =(temperature-32)*5/9 ;
        break;
      default:
        Console.WriteLine("Неверный символ");
        result = 0;
        break;
}
Console.WriteLine($"Результат преобразования равен:{result} ");