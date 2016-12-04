using System.Collections.Generic;
class ConcreteAggregate : IAggregate
{
    private readonly List<object> elem = new List<object>();

    private ConcreteItterator itterator;

    public object this[int index]
    {
        get
        {
            return elem[index];
        }

        set
        {
            elem.Insert(index, value);
        }
    }

    public IItterator CreateItterator()
    {
        itterator = new ConcreteItterator(this);
        return itterator;
    }

    public int Count
    {
        get { return elem.Count; }
    }
}