namespace Homework5;

class Program
{
    static void Main(string[] args)
    {
        // Call Q1_method()
        Q1_method();

        // Call Q2_method()
        Q2_method();

        // Call Q3_method()
        Q3_method();
    }

    // Q1_method:
    static void Q1_method()
    {
        Console.WriteLine("Q1:");
        int largest = LargestOfTwoInputs();
        Console.WriteLine("The largest number is : " + largest);
        Console.WriteLine();
    }

    // Q2_method:
    static void Q2_method()
    {
        Console.WriteLine("Q2:");
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c = ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("d = ");
        int d = int.Parse(Console.ReadLine());

        int max1 = Max(a, b);
        int max2 = Max(c, d);
        int max = Max(max1, max2);

        Console.WriteLine("The largest number is : " + max);
        Console.WriteLine();
    }

    //Q3_method:
    static void Q3_method()
    {
        Console.WriteLine("Q3:");
        createAccount();
        Console.WriteLine();
    }

    // Q1_method:
    static int LargestOfTwoInputs()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());

        return Max(a, b);
    }

    // Q2_method:
    static int Max(int x, int y)
    {
        return (x > y) ? x : y;
    }

    // Q3_method
    static bool checkAge(int birth_year)
    {
        int current_year = DateTime.Now.Year;
        int age = current_year - birth_year;
        return age >= 18;
    }

    static void createAccount()
    {
        Console.Write("Enter Your Username: ");
        string username = Console.ReadLine();

        Console.Write("Enter Your Password: ");
        string password1 = Console.ReadLine();

        Console.Write("Enter Your Password Again: ");
        string password2 = Console.ReadLine();

        Console.Write("Enter Your Birthyear: ");
        int birthyear = int.Parse(Console.ReadLine());

        if (checkAge(birthyear))
        {
            if (password1 == password2)
            {
                Console.WriteLine("Account is created successfully");
            }
            else
            {
                Console.WriteLine("Wrong password");
            }
        }
        else
        {
            Console.WriteLine("Could not create an account");
        }
    }
}
