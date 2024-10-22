
using System.Security.Cryptography.X509Certificates;

public class MyList<TItem>
{
    private TItem[] _array;
    private int _count = 0;
    public int _capacity = 4;

    public int Capacity
    {
        set
        {
            if (_capacity > value)
            {
                System.Array.Resize(ref _array, value);
                _capacity = value;
            }
        }
        get => _capacity;
    }

    public int Count => _count;

    public MyList()
    {
        _array = new TItem[_capacity];
    }

    public MyList(int capacity)
    {
        _array = new TItem[capacity];
        this.Capacity = capacity;
    }

    public void Add(TItem item) 
    {
        if (_count + 1 >= _capacity)
        {
            this.Capacity *= 2;
        }

        _array[_count++] = item;
    }

    public void Remove(TItem item) {}

    public void RemoveAt(int index) {}

    public void Insert(int index, TItem item) {}

    public void Clear() {}

    public string ToString() 
    { 
        return string.Join(", ", _array); 
    }

    public int IndexOf(TItem item)
    {
        return -1;
    }

    public void ForEach(System.Action<TItem> action)
    {

    }

    public TItem Find(System.Func<TItem, bool>  predicate)
    {
        return default(TItem);
    }

    public void Sort(System.Func<int, TItem, TItem> sort)
    {

    }
}