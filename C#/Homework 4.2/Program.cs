System.Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int count = 0;

int[] array = new int[size];

Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(100, 999); 
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
    if (array[i] % 2  == 0)
    {
      count++;
    }
}
Console.WriteLine("");
Console.WriteLine("Количество четных чисел в массиве: " + count);