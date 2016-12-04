using System;

class ConcreteItterator : IItterator
{
    private ConcreteAggregate aggregate;
    private int current;

    public ConcreteItterator(ConcreteAggregate concreteAggregate)
    {
        aggregate = concreteAggregate;
    }

    public object CurrentItem()
    {
        return aggregate[current];
    }

    public object First()
    {
        return aggregate[0];
    }

    public bool IsDone()
    {
        throw new NotImplementedException();
    }

    public object Next()
    {
        object element = null;
        if(current < aggregate.Count - 1){
            element = aggregate[++current];
        }

        return element;
    }
}