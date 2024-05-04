int akkerman(int m_temp, int n_temp)
{
    if (m_temp == 0)
    {
        return n_temp + 1;
    }
    else if (m_temp != 0 && n_temp == 0)
    {
        return akkerman(m_temp - 1, 1);
    }
    else if (m_temp > 0 && n_temp > 0)
    {
        return akkerman(m_temp - 1, akkerman(m_temp, n_temp - 1));
    }
    return akkerman(m_temp, n_temp);
    
}

//////////////////
int m = 0;
int n = 0;

  checkpoint_1:
  System.Console.Write("Введите натуральное число m: "); 
  m = Convert.ToInt32(Console.ReadLine());
  
  if (m <= 0)
  {
    goto checkpoint_1;
  }

  checkpoint_2:
  System.Console.Write("Введите натуральное число n: "); 
  n = Convert.ToInt32(Console.ReadLine());
  
  if (n <= 0)
  {
    goto checkpoint_2;
  }

Console.Write(akkerman(m, n));