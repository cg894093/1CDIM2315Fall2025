namespace Homework4;

class Program
{
    // Question 1
    static int GetLargest(int a, int b)
    {
        if (a > b)
            return a;
        else
            return b;
    }

    // Question 2
    static void PrintTriangle(int N, string shape)
    {
        Console.WriteLine("N is : " + N + "; shape is" + shape);

        if (shape.ToLower() == "left")
        {
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine(new string('*', i));
            }
        }
        else if (shape.ToLower() == "right")
        {
            for (int i = 1; i <= N; i++)
            {
                string spaces = new string(' ', N - i);
                string stars = new string('*', i);
                Console.WriteLine(spaces + stars);
            }
        }
        else
        {
            Console.WriteLine("Invaid shape. Please enter 'left' or 'right'.");
        }
    }
    // Single Main method
    static void Main(string[] args)
    {
         // Question 1 output
        int a = 3;
        int b = 5;

        Console.WriteLine("a = " + a + "; b =" + b);

        int largest = GetLargest(a, b);

        Console.WriteLine("The largest number is :" + largest);
        Console.WriteLine();

        // Question 2 output
        PrintTriangle(5, "left");
        Console.WriteLine();
        PrintTriangle(5, "right");
    }
    
}
