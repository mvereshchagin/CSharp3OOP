// global using System;


using CSharp3OOP; // импортирую все названия из пространства имен CSharp3OOP

using static System.Console; // импортирую все статические методы и свойства класса
using Ccar = CSharp3OOP.Car; // создаю псевдоним класса

// using System;
// using System.Collections.Generic;
// using System.Linq;

using Data;



public class Program
{
    public static void Main()
    {
        WriteLine("dsadsadas");
        var car3 = new Ccar(producer: "Toyota", model: "Camry");

        //Car car1 = new Car(); // создание объекта (слово new => вызвать конструктор)
        var car1 = new Car(producer: "Toyota", model: "Camry");
        // car1._producer = "Lada"; // нельзя
        car1.Model = "Kalina";
        car1.Color = "Yellow";
        var producer1 = car1.GetProducer();
        //car1.YearOfCreate = 2010;

        //Car car2 = new Car(); // создание объекта
        //car2.Producer = "BMW";
        //car2.Model = "X6";
        //car2.Color = "Black";
        ////car2.YearOfCreate = 2020;

        Console.WriteLine(car1.Model);
        //Console.WriteLine(car2.Model);

        var desc = car1.Description;
        // car1.Description = "Цвет мокрый асфальт с царапиной на левом боку";

        car1.Description6 = "Цвет мокрый асфальт с царапиной на левом боку";
        car1.Description6 = "sadhbsahjdbsahjbdashjbdjh  skjcnsadkcn skjdfncksdjfnsdkj" +
            "fjkdsanfkjasndkj  s;ldmflksdmfws" +
            " kjsdfnjksdfnksl dsfmkldsmflkdsmfklsd sdmflsdkfmdsklmfs" +
            "jfnkjsdnfsd sdmflsdkmfsdl;km ;as;ldfmaskl";
        Console.WriteLine(car1.Description6);

        car1.Drive(); // вызов метода


        var (producer, model, description) = car1; // был вызвн метод Deconstruct
        Console.WriteLine($"{producer} {model} {description}");


        // метод возарщает неименовыннй кортеж
        (int, int) GetPosition()
        {
            return (10, 100);
        }

        // метод возвращает именованный кортеж
        (int Left, int Top) GetPosition2()
        {
            return (10, 100);
        }

        (int a, int b) = GetPosition();
        (var c, var d) = GetPosition();
        var (e, f) = GetPosition();
        var k = GetPosition();
        var k1 = k.Item1;
        var k2 = k.Item2;

        var w = GetPosition2();
        Console.WriteLine($"[{w.Left}, {w.Top}]");

        var (q, _) = GetPosition2();

        var curPosition = Console.GetCursorPosition();

        Car.Counter = 0;


        ConsoleUtils.WriteLine("dsadsadsa");


        var point1 = new Point() { X = 100, Y = 200 };
        var point2 = point1;
        point2.X = 300;
        Console.WriteLine($"{point1.X}, {point1.Y}");

        Person? p = new Person();

        p = null;

        var s = p ?? new object();

        if(p is not null)
        {

        }

        int? ab = null;
        if(ab is not null)
        {

        }

        var name = Console.ReadLine();
        if(name is not null)
            PrintName(name);
        PrintName(name!); // null-forgiven operator


        var person1 = new Person()
        {
            FirstName = "Vasya",
            SecondName = "Pupkin",
            Language = new Language()
            {
                Name = "English",
                ShortName = "En"
            }
        };

        var me = new Teacher()
        {
            FirstName = "Mikhail",
            SecondName = "Vereshchagin",
            Position = "Doctor",
        };


        var student = new Student()
        {
            FirstName = "Vasya",
            SecondName = "Pupkin",
            CourseNumber = 2,
        };

        Console.WriteLine(student);

        student.SayHello();

        Person pp = new Student();
        pp = new Teacher();
        pp = new Student();

        // проверка на тип
        if(pp is Student)
        {
            // преобрзаование в тип
            var ppStudent1 = pp as Student;
            var courseNumber = ppStudent1.CourseNumber;
             // ((Student) pp).CourseNumber
        }

        // проверка на тип + преобразование в тип
        if(pp is Student ppStudent)
        {
            var courseNumber1 = ppStudent.CourseNumber;
        }

        Person[] people =
        {
            new Student() { FirstName = "Oleg", SecondName = "Ivanov", CourseNumber = 3},
            new Student() { FirstName = "Ivan", SecondName = "Zinoviev", CourseNumber = 1},
            new Student() { FirstName = "Piotr", SecondName = "Puplkin", CourseNumber = 3},
            new Student() { FirstName = "Dmitry", SecondName = "Kuzntsov", CourseNumber = 2},
            new Student() { FirstName = "Vsevolod", SecondName = "Vasiliev", CourseNumber = 3},
            new Teacher() { FirstName = "Olga", SecondName = "Olgina", Position = "Director"}
        };
        Console.WriteLine("=======================================");
        foreach (var person in people)
            Console.WriteLine(person);
        Console.WriteLine("=======================================");
    }

    private static void PrintName(string name)
    {
        Console.WriteLine($"Hello, {name}");
    }

    private static void PrintLanguage(Person p)
    {
        Console.WriteLine(p?.Language?.ShortName);

        //if (p is null)
        //    return;
        //if (p.Language is null)
        //    return;
        //if (p.Language.ShortName is null)
        //    return;
        //Console.WriteLine(p.Language.ShortName);
    }
}


