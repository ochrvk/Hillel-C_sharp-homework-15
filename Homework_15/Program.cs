
class MyClass<T> where T : IComparable<T>
{

    private List<T> list = new List<T>();

    public void Add(T t)
    {
        list.Add(t);
    }

    public bool IsGreaterOrEqual(T t)
    {
        foreach (var item in list)
        {
            if (t.CompareTo(item) < 0)
            {
                return false;
            }
        }
        return true;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("start");

        MyClass<int> myClass = new MyClass<int>();

        myClass.Add(1);
        myClass.Add(2);

        Console.Write("Enter value: ");
        int value = int.Parse(Console.ReadLine());

        Console.WriteLine(myClass.IsGreaterOrEqual(value));
    }
}
