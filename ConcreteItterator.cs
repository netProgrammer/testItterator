using System;

class ConcreteItterator : IItterator
{
    private ConcreteAggregate concreteAggregate;

    public ConcreteItterator(ConcreteAggregate concreteAggregate)
    {
        this.concreteAggregate = concreteAggregate;
    }

    public object CurrentItem()
    {
        throw new NotImplementedException();
    }

    public object First()
    {
        throw new NotImplementedException();
    }

    public bool IsDone()
    {
        throw new NotImplementedException();
    }

    public object Next()
    {
        throw new NotImplementedException();
    }
}