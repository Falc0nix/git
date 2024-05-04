int count(int mini, int maxi)
{
    if (mini == maxi)
    {
            return mini;
    }
    Console.Write(mini + ", ");
    return count(mini + 1, maxi);
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

int min_value = Math.Min(m, n);
int max_value = Math.Max(m, n);

Console.Write(count(min_value, max_value ));