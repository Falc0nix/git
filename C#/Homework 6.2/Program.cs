
    string query  = "";
    string result  = "";
    Console.Write ("Задайте строку, содержащую латинские буквы в обоих регистрах: ");
    
    query = Console.ReadLine();
    
    while (result == "")
    {
        if (!System.Text.RegularExpressions.Regex.IsMatch(query, (@"[A-Z]")))
        {
            
            Console.Write ("Задайте строку, содержащую ТОЛЬКО латинские буквы в обоих регистрах: ");
            query = Console.ReadLine();
            continue;
        }
        else
        {
        result = query.ToLower();
        }
    }
    

Console.WriteLine (result);