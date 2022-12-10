using CSharp3OOP;

//Car car1 = new Car(); // создание объекта (слово new => вызвать конструктор)
var car1 = new Car(producer: "Toyota", model: "Camry");
// car1._producer = "Lada"; // нельзя
car1.Model = "Kalina";
car1.Color = "Yellow";
var producer = car1.GetProducer();
//car1.YearOfCreate = 2010;

//Car car2 = new Car(); // создание объекта
//car2.Producer = "BMW";
//car2.Model = "X6";
//car2.Color = "Black";
////car2.YearOfCreate = 2020;

Console.WriteLine(car1.Model);
//Console.WriteLine(car2.Model);