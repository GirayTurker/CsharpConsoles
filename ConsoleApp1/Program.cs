// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

namespace ConsoleApp1;

class ConsoleApp1
{

    /*
     Given a number for n, For each integer i in the range from 1 to n inclusive,
     print one value per line as defined in GirayTurker function.
     */
    
    public static void GirayTurker(int n)
    {
        
        
            for ( int i = n - (n-1); i <= n; i++)
            {
                
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("GirayTurker");
                    }
                    else if (i % 3 == 0 && i % 5 != 0)
                    {
                        Console.WriteLine("Giray");
                    }

                    else if (i % 3 != 0 && i % 5 == 0)
                    {
                        Console.WriteLine("Turker");
                    }

                    else if (i % 3 != 0 && i % 5 != 0)
                    {
                        Console.WriteLine(i);
                    }

                    
            }
    }
        
}



static class Solution
{
    public static void Main(string[] args)
    {
        //int n = Convert.ToInt32(Console.ReadLine().Trim());
        
        ConsoleApp1.GirayTurker(5);
       
        
    }
}