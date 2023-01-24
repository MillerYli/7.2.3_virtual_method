using System;
BaseClass bas = new BaseClass();
bas.Display();

DerivedClass derived= new DerivedClass();
derived.Display();
class BaseClass
{
    public virtual void Display()
    {
        Console.WriteLine("Метод класса BaseClass");
    }
}
class DerivedClass : BaseClass
{
    public override void Display()
    {
        Console.WriteLine("Метод класса DeriverClass");
    }
}