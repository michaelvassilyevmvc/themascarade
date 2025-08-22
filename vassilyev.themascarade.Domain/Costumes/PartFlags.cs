namespace vassilyev.themascarade.Domain.Costumes;

[Flags]
public enum PartFlags
{
    None        = 0,
    Headwear    = 1 << 0, // головной убор
    Mask        = 1 << 1,
    UpperWear   = 1 << 2, // верх
    LowerWear   = 1 << 3, // низ
    Footwear    = 1 << 4,
    Accessory   = 1 << 5
}