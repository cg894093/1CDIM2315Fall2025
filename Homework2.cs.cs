namespace Homework2;

class Program
{
    static void Main(string[] args)
    {
        // Question 1
       Console.Write("Please input a letter grade: ");
       string? input = Console.ReadLine();      
       string grade = (input ??"").Trim().ToUpper();    //handles null, spaces, lowercase

       if (grade == "A")
       {
            Console.WriteLine("GPA Point: 4");
       }
       else if (grade == "B")
       {
            Console.WriteLine("GPA Point: 3");
       }
       else if (grade == "C")
       {
            Console.WriteLine("GPA Point: 2");
       }
       else if (grade == "D")
       {
            Console.WriteLine("GPA Point: 1");
       }
       else if (grade == "F")
       {
            Console.WriteLine("GPA Point: 0");
       }
       else
       {
            Console.WriteLine("Wrong letter grade!");
       }

       //Question 2
       Console.Write("Enter the first number: ");
       int num1 = Convert.ToInt16(Console.ReadLine());

       Console.Write("Enter the second number: ");
       int num2 = Convert.ToInt16(Console.ReadLine());

       Console.Write("Enter the third number: ");
       int num3 = Convert.ToInt16(Console.ReadLine());

       //Processing Section (Nested if)
       int smallest;

       if (num1 < num2)
       {
            if (num1 < num3)
                smallest = num1;
            else
                smallest = num3;
       }
       else
       {
            if (num2 < num3)
                smallest = num2;
            else
                smallest = num3;
       }

        //Output Section
        Console.WriteLine("The Smallest number is: " + smallest);
        
        //Bonus
        Console.Write("Please input a year:");
        int year = Convert.ToInt16(Console.ReadLine());

        //Processing Section (Leap Year Check)
        //Rule:
        //-Leap year if divisible by 4 AND not divisible by 100
        //-OR divisivle by 400
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    Console.WriteLine(year + "is a Leap Year.");
                }
                else
                {
                    Console.WriteLine(year + "is not a Leap Yea.");
                }
            }
            else
            {
                Console.WriteLine(year + "is a Leap Year.");
            }
        }
        else
        {
            Console.WriteLine(year + "is not a Leap Year");
        }
    }
}
