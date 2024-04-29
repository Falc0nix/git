int value = 0;
int value_sum = 0;
string value_str = "";


while (value == 0)
{
  System.Console.Write("Введите любое целое число: "); 
  value_str = Console.ReadLine();
  

    if (string.IsNullOrEmpty(value_str))
    {
    System.Console.WriteLine("Ошибка ввода! Пользователь ничего не ввел");
    continue;
    } 
    
    bool success = int.TryParse(value_str, out value);

    if (success == false)
    {
    System.Console.WriteLine("Ошибка ввода! Нечисловой тип данных");
    continue;
    } 

    if (value_str == "q")
  {
    Console.WriteLine("Операция прервана пользователем");
    break;
  }


  value = Convert.ToInt32(value_str);
  


int value_lentgh = value_str.Length;


for (int i = 1; i < value_lentgh; i++)
{
  value_sum = value_sum + Convert.ToInt32(Math.Round(value / Math.Pow(10, value_lentgh - i), 0, MidpointRounding.ToNegativeInfinity));
  value = value % Convert.ToInt32(Math.Pow(10, value_lentgh - i));
}
value_sum = value_sum + value; 

 if (value_sum % 2 == 0)
  {
    Console.WriteLine("Операция прервана! Сумма цифр числа " + value_str + " является четной");
    break;
  }
  else
  {
    value = 0;
    value_sum = 0;
    value_str = "";
  }
}