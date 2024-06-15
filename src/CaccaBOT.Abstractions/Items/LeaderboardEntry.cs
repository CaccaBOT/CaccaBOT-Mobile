namespace CaccaBOT.Abstractions.Items;

public sealed record LeaderboardEntry
(
    UserId Id,
    string Username,
    uint Rank,
    uint Poops,
    Uri? Pfp,
    string? Bio,
    bool Frozen
);
