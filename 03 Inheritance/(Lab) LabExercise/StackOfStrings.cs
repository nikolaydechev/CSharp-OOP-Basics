
using System.Collections.Generic;

public class StackOfStrings
{
    private List<string> data;

    public void Push(string item)
    {
        this.data.Add(item);
    }

    public string Pop()
    {
        string item = data[data.Count - 1];
        this.data.RemoveAt(data.Count - 1);
        return item;
    }

    public string Peek()
    {
        return this.data[data.Count - 1];
    }

    public bool IsEmpty()
    {
        if (this.data.Count < 1)
        {
            return true;
        }
        return false;
    }
}