using vassilyev.themascarade.Domain.Abstractions;

namespace vassilyev.themascarade.Domain.Rentals;

public sealed class Rental : Entity
{
    public Rental(Guid id, Guid costumeId, Guid customerId, RentalStatus status, DateOnly start, DateOnly end,
        Money price) : base(id)
    {
        CostumeId = costumeId;
        CustomerId = customerId;
        Status = status;
        StartDate = start;
        EndDate = end;
        Price = price;
    }

    public Guid CostumeId { get; init; } // FK -> Costume
    public Guid CustomerId { get; init; } // FK -> Customer
    public RentalStatus Status { get; private set; } = RentalStatus.Reserved;
    public DateOnly StartDate { get; private set; }
    public DateOnly EndDate { get; private set; } // End > Start
    public Money Price { get; private set; }

    public static Rental Create(Guid costumeId, Guid customerId, RentalStatus status, DateOnly start, DateOnly end,
        Money price)
    {
        var rental = new Rental(Guid.NewGuid(), costumeId, customerId, status, start, end, price);
        return rental;
    }
}