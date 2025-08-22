using vassilyev.themascarade.Domain.Abstractions;

namespace vassilyev.themascarade.Domain.Customers;

public sealed class Customer: Entity
{
    public Customer(Guid id) : base(id)
    {
    }

    public string FullName { get; private set; } = default!;
    public string Phone { get; private set; } = default!;
    public string? Email { get; private set; }
    public LoyaltyLevel LoyaltyLevel { get; private set; } = LoyaltyLevel.Regular;
    
}