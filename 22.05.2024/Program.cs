using DocumentFormat.OpenXml.Spreadsheet;
using System.Collections;

public class Penis<T>
{
    internal T[] items;
    internal int size;

    private static readonly T[] s_emptyArray = new T[0];
    public Penis()
    {
        items = s_emptyArray;
    }

    public int Count => size;

    public static bool operator !=(Penis<T> a, Penis<T> b)
    {
        return a != b;
    }
    public static bool operator ==(Penis<T> a, Penis<T> b)
    {
        return a == b;
    }



    public void Add(T item)
    {
        size++;
        items[size] = item;
    }

    public void Clear()
    {
        size = 0;
        items = s_emptyArray;
    }

    public bool Contains(T item)
    {
        return size != 0 && IndexArr(item) >= 0;
    }
    public int IndexArr(T item) => Array.IndexOf(items, item, 0, size);
    public void CopyTo(T[] array, int arrayIndex)
    {
        array.CopyTo(array, arrayIndex);
    }
}



class Start
{
    static void Main(string[] args)
    {
        
    }
}