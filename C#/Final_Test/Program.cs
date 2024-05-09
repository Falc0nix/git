int size = 0;
string pre_size = "";


checkpoint:
System.Console.Write("Введите размер массива: ");

pre_size = Console.ReadLine();

if (int.TryParse(pre_size, out size) == false)
{
    goto checkpoint;
}

if (size <= 0)
{
    goto checkpoint;
}



string[] myarray = new string[size];

for (int i = 0; i < myarray.Length; i++)
{
    System.Console.Write($"Введите {i+1}-й элемент текстового массива: ");
    myarray[i] = Console.ReadLine(); 
    System.Console.WriteLine("");

    while (myarray[i] == "")
    {
        if (myarray[i] == "")
        {
            
            Console.Write ($"{i+1}-й элемент текстового массива НЕ ВВЕДЕН. Введите {i+1}-й элемент текстового массива: ");
            myarray[i] = Console.ReadLine();
            continue;
        }
    }
    
}





System.Console.WriteLine("Исходный массив: ");

for (int i = 0; i < myarray.Length; i++)
{
    System.Console.Write(myarray[i] + " ");
} 

string[] result = new string[0];

System.Console.WriteLine("");
System.Console.WriteLine("");
System.Console.WriteLine("Конечный массив: ");

foreach (var e in myarray)
{
    
    if (e.Length <=3)
    {
        Array.Resize(ref result, result.Length + 1);
        result[result.Length - 1] = e;
        Console.Write(e);
    }
            
}