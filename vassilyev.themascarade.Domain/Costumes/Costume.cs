using vassilyev.themascarade.Domain.Abstractions;

namespace vassilyev.themascarade.Domain.Costumes;

public sealed class Costume: Entity
{
    public Costume(Guid id, Name name, CostumeCondition condition, PartFlags parts, Size size):base(id)
    {
        Name = name;
        Category = CostumeCategory.Other;
        Condition = condition;
        Parts = parts;
        Size = size;
    }
    
    public Name Name { get; private set; } 
    public CostumeCategory Category { get; private set; }
    public CostumeCondition Condition { get; private set; } = CostumeCondition.Good;
    public PartFlags Parts { get; private set; } = PartFlags.None; // None => цельный
    public Size Size { get; private set; }
    
    public static Costume Create(Name name, CostumeCondition condition, PartFlags parts, Size size)
    {
        var costume = new Costume(Guid.NewGuid(), name, condition, parts, size);
        return costume;
    }
}