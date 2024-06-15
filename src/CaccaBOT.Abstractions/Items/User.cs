namespace CaccaBOT.Abstractions.Items;

public sealed record User
(
    UserId Id,
    string Username,
    uint Poops = 0,
    Uri? Pfp = null,
    string? Bio = null,
    bool Frozen = false
);
