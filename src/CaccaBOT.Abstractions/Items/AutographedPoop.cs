namespace CaccaBOT.Abstractions.Items;

public sealed record AutographedPoop
(
    PoopId Id,
    UserId UserId,
    DateTime Timestamp,
    string Username
);
