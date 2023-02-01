using System.Collections.Generic;
using System; 

public class FizzBuzz
{   
    public static string[] DoFizzBuzz(int[] values)
    {   
        return values.Select(value => 
        {
            if (value % 5 == 0 && value % 3 == 0) return "FizzBuzz";
            if (value % 5 == 0) return "Buzz";
            if (value % 3 == 0) return "Fizz";
            return value.ToString();
        }).ToArray();
    }
}