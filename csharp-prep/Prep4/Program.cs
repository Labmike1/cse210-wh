using System;
using System.Collections.Generic;

class Program
{ 
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int number = -1;
        int sumar = 0; 
        float average = 0;
        while (number != 0)
        {
            Console.Write("  Enter a list of numbers, type 0 when finished.");
             
            string userlist = Console.ReadLine();
            number = int.Parse(userlist);

            
            if (number != 0){
                numbers.Add(number);

                sumar = sumar + number;
            }
            average = ((float)sumar) / numbers.Count;
             
             
        }
        int max = numbers[0]; 
             foreach (int Number in numbers)
        {
            if (Number > max)
            {
                // if this number is greater than the max, we have found the new max!
                max = Number;
            }
        }   
    Console.WriteLine($"The sum is: {sumar}");
    Console.WriteLine($"The average is: {average}");     
    Console.WriteLine($"The max is: {max}");     
    }
}