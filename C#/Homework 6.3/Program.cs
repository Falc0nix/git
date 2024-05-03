
    string query  = "";
    string result  = "";
    Console.Write ("Задайте строку произвольную текстовую строку (давайте проверим, будет ли она являться палиндромом: ");
    
    query = Console.ReadLine();
    
    while (result == "")
    {
        if (query == "")
        {
            
            Console.Write ("Текстовая строка не введена. Задайте строку произвольную текстовую строку: ");
            query = Console.ReadLine();
            continue;
        }
        else
        {

            char[] stringArray = query.ToCharArray();
            Array.Reverse(stringArray);
            result = new string(stringArray);
        }
    }
    

if (query == result)
{
     Console.WriteLine ($"Заданная строка {query} является палиндромом");
}
else
{
    Console.WriteLine ($"Заданная строка {query} НЕ является палиндромом");
}

