int value = 0;

int lowerlimit = 10;
int upperlimit = 99;
int maximum = 0;


while (value == 0) 
{
  System.Console.Write($"Введите целое число из диапазона ({lowerlimit}, {upperlimit}) : "); 
  value = Convert.ToInt32(Console.ReadLine());
  
  if ((value > upperlimit) ^ (value < lowerlimit))
  {
    value = 0;
    continue;
  }

}


int value_digit = value % 10;
int value_decimal = value / 10;

if (value_digit >= value_decimal)
{
    maximum = value_digit;
}
else
{
    maximum = value_decimal;
}

Console.WriteLine($"В полученном числе {value} максимальная цифра - {maximum}");