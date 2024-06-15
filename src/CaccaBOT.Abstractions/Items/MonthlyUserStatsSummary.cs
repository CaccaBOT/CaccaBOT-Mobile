namespace CaccaBOT.Abstractions.Items;

public sealed record MonthlyUserStatsSummary
(
    uint MonthlyLeaderboardPosition,
    uint Streak,
    decimal PoopAverage
);
