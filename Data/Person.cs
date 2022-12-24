namespace Data;
public class Person : System.Object
{
    public Person()
    { }

    public Person(string firstName, string secondName)
    {
        FirstName = firstName;
        SecondName = secondName;
    }

    public string FirstName { get; set; } = null!;

    public string SecondName { get; set; } = null!;

    public Language? Language { get; set; }

    public override string ToString()
    {
        return $"{FirstName} {SecondName}";
    }

    public virtual void SayHello()
    {
        Console.WriteLine($"Hello, {this}");
    }

    public void DoSomething()
    {

    }
}

public class Teacher : Person
{
    public Teacher()
    { }

    public Teacher(string firstName, string secondName) : base(firstName, secondName)
    {

    }

    public string Position { get; set; } = null!;

    public override string ToString()
    {
        return $"Teacher: {base.ToString()} {Position}";
    }
}

public class Student : Person
{
    public Student()
    { }

    public Student(string firstName, string secondName, int courseNumber) : 
        base(firstName, secondName)
    {
        CourseNumber = courseNumber;
    }

    public int CourseNumber { get; set; }

    public override string ToString()
    {
        return $"{base.ToString()} {CourseNumber}";
    }

    public override void SayHello()
    {
        Console.WriteLine($"Hello, student, {this}");
    }

    /// <summary>
    /// срктие метода
    /// </summary>
    public new void DoSomething()
    {

    }
}
