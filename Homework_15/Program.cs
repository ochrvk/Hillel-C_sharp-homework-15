

/*
Создать класс со следующими методами:
Add - принимает значение любого типа (который реализует IComparable<T>) 
    и сохраняет его в коллекцию (List)
IsGreaterOrEqual - принимает значение любого типа 
    (который реализует IComparable<T>) и возвращает true если оно больше 
        или равно чем каждый элемент коллекции и false если нет

Использовать обобщения
Организовать сравнение с помощью IComparable<T>. 
Его метод CompareTo возвращает число меньше 0 если класс меньше,
    0 - равен и больше 0 если он больше чем другой.
*/




class MyClass<T> : IComparable<T>
{
    List<T> list = new List<T>();


    public void Add(T t)
    {
        list.Add(t);
    }

    public int CompareTo(T? other)
    {
        if (/*code here*/false)
        {
            return 0;
        }
        else if (/*code here*/true)
        {
            return -1;
        }
        else
        {
            return 1;
        }
    }



    public bool isGreaterOrEqual(MyClass<T> t)
    {
        //code here
        return false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("start");

        MyClass<int> myClass = new MyClass<int>();



    }
}
