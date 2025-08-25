using vassilyev.themascarade.Domain.Abstractions;

namespace vassilyev.themascarade.Domain.Customers;

public sealed class Customer: Entity
{
    public Customer(Guid id, FullName fullName, Phone phone, Email email, LoyaltyLevel level) : base(id)
    {
        FullName = fullName;
        Phone = phone;
        Email = email;
    }

    public FullName FullName { get; private set; }
    public Phone Phone { get; private set; }
    public Email Email { get; private set; }
    public LoyaltyLevel LoyaltyLevel { get; private set; } = LoyaltyLevel.Regular;

    public static Customer Create(FullName fullName, Phone phone, Email email, LoyaltyLevel level)
    {
        var customer = new Customer(Guid.NewGuid(), fullName, phone, email, level);
        return customer;
    }
    
}