namespace Homework6;

class Program
{
    static void Main(string[] args)
    {
        // Create 2 Professors
        Professor prof1 = new Professor("Alice", "Java", 9000);
        Professor prof2 = new Professor("Bob", "Math", 8000);

        // Create 2 Students
        Student student1 = new Student("Lisa", "Java", 90);
        Student student2 = new Student("Tom", "Math", 80);

        // Print Professor details
        Console.WriteLine($"Professor {prof1.ProfName} taches {prof1.ClassTeach}, and the salary is: {prof1.GetSalary()}");
        Console.WriteLine($"Professor {prof2.ProfName} teaches {prof2.ClassTeach}, and the salary is: {prof2.GetSalary()}");

        // Print Student details
        Console.WriteLine($"Student {student1.StudentName} enrolls {student1.ClassEnroll}, and the grade is: {student1.GetGrade()}");
        Console.WriteLine($"Student {student2.StudentName} enrolls {student2.ClassEnroll}, and the grade is: {student2.GetGrade()}");

        //Calculate and print salary difference
        double salaryDifference = prof1.GetSalary() - prof2.GetSalary();
        Console.WriteLine($"The salary difference between {prof1.ProfName} and {prof2.ProfName} is: {salaryDifference}");

        //Claculate and print total grade
        double totalGrade = student1.GetGrade() + student2.GetGrade();
        Console.WriteLine($"The total grade of {student1.StudentName} and {student2.StudentName} and {student2.StudentName} is: {totalGrade}");
    }
}

class Professor
{
    //Privat attributes
    private string profName;
    private string classTeach;
    private double salary;

    //Constructor
    public Professor(string name, string calssName, double salaryAmount)
    {
        profName = name;
        classTeach = calssName;
        salary = salaryAmount;
    }

    //Properties (read-only for nake and class)
    public string ProfName
    {
        get { return profName; }
    }

    public string ClassTeach
    {
        get { return classTeach; }
    }

    // Methods
    public void SetSalary(double salary_amount)
    {
        salary = salary_amount;
    }

    public double GetSalary()
    {
        return salary;
    }
}

class Student
{
    //private attributes
    private string studentName;
    private string classEnroll;
    private double studentGrade;

    // Constructor
    public Student(string name, string className, double grade)
    {
        studentName = name;
        classEnroll = className;
        studentGrade = grade;
    }
    
    // Properties (read-only for name and class)
    public string StudentName
    {
        get { return studentName; }
    }

    public string ClassEnroll
    {
        get { return classEnroll; }
    }

    // Methods
    public void SetGrade(double newGrade)
    {
        studentGrade = newGrade;
    }

    public double GetGrade()
    {
        return studentGrade;
    }
}
