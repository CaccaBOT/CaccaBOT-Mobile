namespace CaccaBOT.Abstractions.Items;

public sealed record Poop
(
    PoopId Id,
    UserId UserId,
    DateTime Timestamp
);
