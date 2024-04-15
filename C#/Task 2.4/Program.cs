System.Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];

Random rand = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 10); 
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}