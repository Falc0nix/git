System.Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myarray = new int[size];

Random rand = new Random();

for (int i = 0; i < myarray.Length; i++)
{
    myarray[i] = rand.Next(1, 100); 
}

Console.WriteLine("Исходный массив: ");

for (int i = 0; i < myarray.Length; i++)
{
    Console.Write(myarray[i] + " ");
}    
Array.Reverse(myarray);

Console.WriteLine("");
Console.WriteLine("Обратный массив: ");

for (int i = 0; i < myarray.Length; i++)
{
    Console.Write(myarray[i] + " ");
}    ;