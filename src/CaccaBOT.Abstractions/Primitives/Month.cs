namespace CaccaBOT.Abstractions.Primitives;

public readonly record struct Month
{
    public readonly int Year { get; }
    public readonly uint Number { get; }

    public Month() : this(1, 1) { }

    public Month(int Year, uint Number)
    {
        ArgumentOutOfRangeException.ThrowIfZero(Year);
        ArgumentOutOfRangeException.ThrowIfLessThan(Number, 1u);
        ArgumentOutOfRangeException.ThrowIfGreaterThan(Number, 12u);

        this.Year = Year;
        this.Number = Number;
    }
};
