using System.ComponentModel;

public interface First
{
    void First();
}
public interface Second
{
    void Second();
}
public delegate void Del();
public class X : First, Second
{
    private Del Da { get; set; }
    private event Del delHandler
    {
        add { Da += value; }
        remove { Da -= value; }
    }
    public X()
    {
        delHandler += A;
        delHandler += B;
    }
    void First.First()
    {
        A();
    }
    private void A()
    {
        Console.WriteLine("A");
    }
    void Second.Second()
    {
        B();
    }
    private void B()
    {
        Console.WriteLine("B");
    }
    public void InvokeDelegates()
    {
        Da.Invoke();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        X x = new X();

        x.InvokeDelegates();
    }
}
