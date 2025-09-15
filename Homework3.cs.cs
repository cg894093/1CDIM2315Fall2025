namespace Homework3;

class Program
{
    static void Main(string[] args)
    {
        // Code for Q1
        Console.Write("Input an integer: ");
        int N= Convert.ToInt32(Console.ReadLine());// Declare N once here

        if(N<=1)
        {
            Console.WriteLine($"{N} is non-prime");
        }
        else 
        {
            bool isPrime = true;
            for (int i= 2; i<= N - 1; i++)
            {
                if (N % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

        if (isPrime)
            Console.WriteLine($"{N} is prime.");
        else
            Console.WriteLine($"{N} is non-prime.");
        }

        // Code for Q2
        Console.Write("Assign an int value to N: ");
        N = Convert.ToInt32(Console.ReadLine());

        for (int row = 0; row <N; row++)
        {
            for (int col = 0; col <N; col++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }

        // Code for Q3
        Console.Write("Assign an int value to N:");
        N = Convert.ToInt32(Console.ReadLine());

        for (int row = 1; row <=N; row++)
        {
            for (int col=1; col <=row; col++)
            {
                    Console.Write("*"); 
            }
            Console.WriteLine();
        }

        //Code for Bounus
        Console.Write("Enter a number N:");
        N = int.Parse(Console.ReadLine());

        for (int i=1; i <= N; i++)
        {
            for (int j = 1; j <= N - 1; j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k<= i; k++)
            {
                Console.Write(i);
            }
            
            Console.WriteLine();
        }
           
    }
}
