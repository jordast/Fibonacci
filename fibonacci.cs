using System.IO;
using System;
using System.Diagnostics;
 
class Program
{
    static void Main()
    {
        Console.WriteLine("Running tests");
        try
        {
            Test(1, 1);
            Test(2, 1);
            Test(3, 2);
            Test(10, 55);
            Test(44, 701408733);  
            Test(47, 2971215073); 
            Test(0, 0); 
        }
        catch (Exception e)
        {
            Console.WriteLine("Catastrophic error while executing tests " + e);
        }
 
 
        Console.WriteLine("Completed.");
 
    }
 
    private static void Test(int input, long expected)
    {
        var actual = fibunacci(input);
        if (actual != expected)
        {
            Console.WriteLine(string.Format("Test failed. Got {0} but expected {1}", input, expected));
            Environment.Exit(-1);
        }
        else
        {
            Console.WriteLine(string.Format("Test passed for {0} (={1})", input, expected));
 
        }
    }
 
    /// --- fibunacci (1 parameter)
    /// <summary>
    /// Starts recursion and initialize the memeory array that stores such values
    /// that has been already found by recursion
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    private static Int64 fibunacci(Int64 value)
    {
        if (value <= 1) return value;
 
        Int64[] memory = new Int64[value + 1];
        return fibunacci(value, memory);
    }
 
    /// --- fibunacci (2 parameters)
    /// <summary>
    /// Returns value of the fibunacci sequence at given position
    /// </summary>
    /// <param name="value"></param>
    /// <param name="memory"></param>
    /// <returns></returns>
    private static Int64 fibunacci(Int64 value, Int64[] memory)
    {
        if (value == 1 || value == 2)
        {
            return 1;
        }
        else
        {
            if (memory[value] > 0) return memory[value];
            memory[value] = fibunacci(value - 1, memory) + fibunacci(value - 2, memory);
            return memory[value];
        }
    }
}
