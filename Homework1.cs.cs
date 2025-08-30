namespace Homework1;

class Program
{
    static void Main(string[] args)
    {
        // Define values
        double X=2.5;
        double Y=3.3;

        // Calculate Z
        double Z=4*X*X+3*Y;

        // Print result with formatted string
        Console.WriteLine($"When X={X} and Y={Y}, Z={Z:F2}");

    }
}
