using System.Diagnostics.Metrics;

class Driver
{
    private static void Main(string[] args)
    {
        FibInteration a = new FibInteration();
        FibFormula b = new FibFormula();
        Console.WriteLine("Enter the number you want to find the Fibonacci Series for:") ;
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Fib of 10 by iteration is: "+a.CalculateFib(num));
        Console.WriteLine("Fib of 10 by formula is: "+b.CalculateFib(num));

    }
}