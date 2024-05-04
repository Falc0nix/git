    void print_array(int [] array_temp, int count) 
    { 
      if (count > 0) 
      { 
      	Console.Write(array_temp[count] + " "); 
      	print_array(array_temp, count - 1); 
      } 
      else Console.WriteLine(array_temp[0]); 
    } 

    /////////////
    ///

      int [] array = {2, 8, 16, 32, 64, 128}; 
      print_array(array, array.Length - 1); 

