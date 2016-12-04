interface IAggregate
{
    IItterator CreateItterator();
    object this[int index] { get; set;}
}