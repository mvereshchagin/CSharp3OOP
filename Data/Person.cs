namespace Data;
public class Person : System.Object
{
    protected const string UniqueName = "Person";
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
        Console.WriteLine("Person is doing something");
    }

    public override int GetHashCode()
    {
        return FirstName.GetHashCode();
    }

    public override bool Equals(object? obj)
    {
        if (obj is not Person)
            return false;

        var other = obj as Person;
        if (other is null)
            return false;

        return this.GetHashCode() == other.GetHashCode();
    }
}

public class Teacher : Person
{
    protected new const string UniqueName = "Teacher";
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

    public override void SayHello()
    {
        Console.Write($"Hello, teacher, {this}");
    }

    public new void DoSomething()
    {
        Console.WriteLine("Teacher is doing something");
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
    /// скрытие метода
    /// </summary>
    public new void DoSomething()
    {

    }
}
