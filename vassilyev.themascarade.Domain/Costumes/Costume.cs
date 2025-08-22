using vassilyev.themascarade.Domain.Abstractions;

namespace vassilyev.themascarade.Domain.Costumes;

public sealed class Costume: Entity
{
    public Costume(Guid id):base(id)
    {
        
    }
    
    public string Name { get; private set; } = default!;
    public CostumeCategory Category { get; private set; }
    public CostumeCondition Condition { get; private set; } = CostumeCondition.Good;
    public PartFlags Parts { get; private set; } = PartFlags.None; // None => цельный
    public Size Size { get; private set; }
}