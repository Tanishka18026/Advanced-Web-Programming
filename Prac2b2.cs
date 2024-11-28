// Single Inheritance
class BaseClass1
{
    public void MethodA()
    {
        System.Console.WriteLine("BaseClass1 MethodA");
    }
}

class DerivedClass1 : BaseClass1
{
    public void MethodB()
    {
        System.Console.WriteLine("DerivedClass1 MethodB");
    }
}

// Multilevel Inheritance
class BaseClass2
{
    public void MethodC()
    {
        System.Console.WriteLine("BaseClass2 MethodC");
    }
}

class DerivedClass2 : BaseClass2
{
    public void MethodD()
    {
        System.Console.WriteLine("DerivedClass2 MethodD");
    }
}

class DerivedClass3 : DerivedClass2
{
    public void MethodE()
    {
        System.Console.WriteLine("DerivedClass3 MethodE");
    }
}

// Hierarchical Inheritance
class BaseClass3
{
    public void MethodF()
    {
        System.Console.WriteLine("BaseClass3 MethodF");
    }
}

class DerivedClass4 : BaseClass3
{
    public void MethodG()
    {
        System.Console.WriteLine("DerivedClass4 MethodG");
    }
}

class DerivedClass5 : BaseClass3
{
    public void MethodH()
    {
        System.Console.WriteLine("DerivedClass5 MethodH");
    }
}

// Multiple Inheritance through Interfaces
interface Interface1
{
    void MethodI();
}

interface Interface2
{
    void MethodJ();
}

class DerivedClass6 : Interface1, Interface2
{
    public void MethodI()
    {
        System.Console.WriteLine("DerivedClass6 MethodI");
    }

    public void MethodJ()
    {
        System.Console.WriteLine("DerivedClass6 MethodJ");
    }
}

class MainClass
{
    static void Main()
    {
        // Single Inheritance
        DerivedClass1 obj1 = new DerivedClass1();
        obj1.MethodA();
        obj1.MethodB();

        // Multilevel Inheritance
        DerivedClass3 obj2 = new DerivedClass3();
        obj2.MethodC();
        obj2.MethodD();
        obj2.MethodE();

        // Hierarchical Inheritance
        DerivedClass4 obj3 = new DerivedClass4();
        obj3.MethodF();
        obj3.MethodG();

        DerivedClass5 obj4 = new DerivedClass5();
        obj4.MethodF();
        obj4.MethodH();

        // Multiple Inheritance through Interfaces
        DerivedClass6 obj5 = new DerivedClass6();
        obj5.MethodI();
        obj5.MethodJ();
    }
}
