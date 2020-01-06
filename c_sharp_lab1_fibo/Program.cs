using System;
using System.ComponentModel;

namespace c_sharp_capp
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("nhap so can kiem tra\n");
      int n = Int32.Parse(Console.ReadLine());
      int fib = 0;
      int i = 0;
      
      while (fibonacci(i) < n)
      {
        fib = fibonacci(i);
        i++;
      }
      Console.WriteLine("so fibonaci gan va nho hon "+n+" la: "+fib);
    }

    public static int fibonacci(int n)
    {
      if (n < 0)
      {
        return -1;
      }
      else if (n == 0 || n == 1)
      {
        return n;
      }
      else
      {
        return fibonacci(n - 1) + fibonacci(n - 2);
      }
    }
  }
}