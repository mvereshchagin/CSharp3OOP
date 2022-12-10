﻿namespace CSharp3OOP;

// Опрделение класса
class Car
{
    // конструктор ctor
    // Называется также как и класс и не пишется возвращаемое значение
    // Если конструктор в явном виде не указан, то подразумевцается 
    // конструктор по умолчанию public название_класса() {}
    // Если конструктор private, protected или ничего не указано = private
    // то экхемпляр данного класса создать нельзя
    // Конструктор без параметров
    //public Car() : this(producer: null)
    //{
    //    Console.WriteLine("Ctor 0 paramaters");
    //}

    //public Car(string producer) : this(producer: producer, model: null)
    //{
    //    Console.WriteLine("Ctor 1 paramater");
    //}

    public Car(string producer, string model)
    {
        this._producer = producer; // this = текущий экземпляр класса. Можнол писать, можно не писать
        Model = model;

        Console.WriteLine("Ctor 2 paramaters");

        // here is somthing complicated
    }

    #region Fields
    // модификаторы доступа для полей
    // public - виден вне класса везде. Называем с большой буквы
    // private - виден только внутри класса (по умолчанию). Называем напчиная я _маленькая буквы
    // protected - виден внутри класса и внутри потомков класса. Называем аналогично private
    // Доступны везде внутри класса
    public string Color;
    public string Model;
    private int _yearOfCreate;
    // readonly = менять можно только в конструкторе
    private readonly string _producer;
    private string _fullName;
    protected string _description;
    #endregion

    #region Properties (инициализаторы)
    public void SetYearOfCreate(int yearOfCreate)
    {
        _yearOfCreate = yearOfCreate;
    }

    public int GetYearOfCreate()
    {
        return _yearOfCreate;
    }

    public string GetProducer()
    {
        return _producer;
    }

    //private void DoSomething()
    //{
    //    _producer = "Lada";
    //}
    #endregion
}
