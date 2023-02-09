
using System;

public class Fibonacci
{
    public static void Main(string[] args)
    {
       
        int n1 = 0, n2 = 1, n3, i;

        
        int[] series = new int[25];

        
        series[0] = n1; 
        series[1] = n2; 

        
        for (i = 2; i < 25; ++i)    
        {
            n3 = n1 + n2;
            series[i] = n3;
            n1 = n2;
            n2 = n3;
        }
        
        for (i = 0; i < 25; i++)
        {
            Console.WriteLine("Fibonacci number (" + i + ") = " + series[i]);
        }
    }
}