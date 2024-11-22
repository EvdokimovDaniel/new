namespace task2;

class Program
{
    static void Main(string[] args)
    {
       int x = 1;
       if (x > 5)
       {
           Console.WriteLine("x больше 5");
       }
        else if (x > 0)
        {
            Console.WriteLine("x больше нуля");
        }
        else if (x < 0)
        {
            Console.WriteLine("x меньше нуля");
        }
        else
       {
          Console.WriteLine("x равен нулю");
       }
    }
}
