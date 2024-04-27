
int x = 0;
int y = 0;

while (x == 0)
{
  System.Console.Write("Введите координату x: "); 
  x = Convert.ToInt32(Console.ReadLine());
  
  if (x == 0)
  {
    continue;
  }
  else
  {
  break;
  } 
}

while (y == 0)
{
  System.Console.Write("Введите координату y: "); 
  y = Convert.ToInt32(Console.ReadLine());
  
  if (y == 0)
  {
    continue;
  }
  else
  {
  break;
  } 
}

if (x > 0 && y > 0)
  {
    Console.WriteLine($"Заданное точка с координатами ({x}, {y}) находится в 1 четверти координатной плоскости");
  }
else if (x < 0 && y > 0)
  {
    Console.WriteLine($"Заданное точка с координатами ({x}, {y}) находится в 2 четверти координатной плоскости");
  }
  else if (x < 0 && y < 0)
  {
    Console.WriteLine($"Заданное точка с координатами ({x}, {y}) находится в 3 четверти координатной плоскости");
  }
    else if (x > 0 && y < 0)
  {
    Console.WriteLine($"Заданное точка с координатами ({x}, {y}) находится в 4 четверти координатной плоскости");
  }