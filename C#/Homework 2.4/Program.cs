int value = 0;


while (value == 0)
{
  System.Console.Write("Введите натуральное число: "); 
  value = Convert.ToInt32(Console.ReadLine());
  
  if (value < 0)
  {
    continue;
  }
  else
  {
  break;
  } 
}


int value_lentgh = value.ToString().Length;

Console.Write("Введенное число состоит из следующих цифр: ");

for (int i = 1; i < value_lentgh; i++)
{
  Console.Write(Math.Round(value / Math.Pow(10, value_lentgh - i), 0, MidpointRounding.ToNegativeInfinity) + ", ");
  value = value % Convert.ToInt32(Math.Pow(10, value_lentgh - i));
}

Console.Write(value);
