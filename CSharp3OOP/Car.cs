namespace CSharp3OOP;
using System;


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

    // свойство только для чтения
    public string Description { get; }

    // Свойство на чтение и на запись
    public string Descrption2 { get; set; }

    // Поле только неа чтение, связанное с переменной класаа _description 
    // короткая запись
    public string Descriptin3 => _description;

    public string Descroption4
    {
        get
        {
            // какие-то манипуляции до отдачи значения
            return _description;
        }
    }

    public string Description5
    {
        get => _description;
    }

    public string Description6
    {
        get
        {
            return _description;
        }
        set
        {
            if (String.IsNullOrEmpty(value) || value.Length > 56)
            {
                Console.WriteLine("Слишком длинная строка. Игнорирую");
                return;
            }
            _description = value;
        }
    }

    public string Description7
    {
        get => _description;
        set
        {
            if (String.IsNullOrEmpty(value) || value.Length > 56)
            {
                Console.WriteLine("Слишком длинная строка. Игнорирую");
                return;
            }
            _description = value;
        }
    }
    #endregion

    #region методы
    public void Drive()
    {
        Console.WriteLine($"{_producer} {Model} has started");
        counter++;
    }

    public string WhatHappened()
    {
        return "bla-bla-bla";
    }

    public void PrintInfo(DateTime date)
    {
        Console.WriteLine($"{date:dd.MM.yyyy}: {_producer} {Model}");

        if(true)
        {
            int a = 10;

        }
    }


    public static int Sum(int a, int b, int c = 0)
    {
        return a + b + c;
    }
    #endregion

    // Деструктор
    // Выхывается, когда объект убивается
    // напрясую в C# с ним не работаем
    ~Car()
    {

    }

    // Деконструктор
    // Разложение класса в кортеж
    public void Deconstruct(out string producer, out string model, out string description)
    {
        producer = _producer;
        model = Model;
        description = _description;
    }

    private static int counter = 0;

    public static int Counter;
}
