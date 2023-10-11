// See https://aka.ms/new-console-template for more information

int result = Fibonacci(6);

Console.WriteLine("\nFibonacci Array Elements:");
foreach (var number in arrFibonacci(result))
{
    Console.WriteLine((Convert.ToString(number)));
}


Console.WriteLine("\nTotal line of the Fibonacci series: "+result);
Console.WriteLine("\nSum of each line respectively:");

int k = 0;

for (int i = 0; i <= result; i++)
{
    int fibNums = Fibonacci(i);
    if (fibNums>=1)
    {
        Console.WriteLine("Sum of "+k+" line: "+fibNums);
    }
    k++;
}

static int[] arrFibonacci(int n)
{
    int[] fibArr = new int[n];
    
    for (int i = 0; i < n; i++)
    {
        fibArr[i] = Fibonacci(i+1);
       
    }
    return fibArr;
    
}

static int Fibonacci(int n)
{
    int n1 = 0;
    int n2 = 1;
    int sum =0;

    if (n<=1)
    {
        return n;
    }
    else
    {
        for (int i = 2; i <= n; i++)
        {
            sum = n1 + n2;
            n1 = n2;
            n2 = sum;
        }

        return sum;
    }
    
}

static int fiboEvenSum(int n)
{
    int sum = 0;

    for (int i = 0; i <= n; i++)
    {
        if (i % 2 == 0)
        {
            sum += i;
        }
    }

    return sum;
}