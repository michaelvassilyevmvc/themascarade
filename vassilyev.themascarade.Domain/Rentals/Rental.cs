using vassilyev.themascarade.Domain.Abstractions;

namespace vassilyev.themascarade.Domain.Rentals;

public sealed class Rental: Entity
{
    public Rental(Guid id):base(id)
    {
        
    }
    
    public Guid CostumeId { get; init; }     // FK -> Costume
    public Guid CustomerId { get; init; }    // FK -> Customer
    public RentalStatus Status { get; private set; } = RentalStatus.Reserved;
    public DateOnly StartDate { get; private set; }
    public DateOnly EndDate { get; private set; }       // End > Start
    public decimal TotalAmount { get; private set; }    // >= 0
    public string Currency { get; private set; } = "KZT"; // ISO 4217 (3 буквы)
}