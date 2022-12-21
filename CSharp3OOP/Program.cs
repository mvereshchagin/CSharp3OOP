using CSharp3OOP;

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

{
    var car3 = new Car(producer: "Renault", model: "Logan");

    
}

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




