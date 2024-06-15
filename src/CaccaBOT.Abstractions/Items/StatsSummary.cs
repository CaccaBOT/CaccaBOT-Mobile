namespace CaccaBOT.Abstractions.Items;

public sealed record StatsSummary
(
    uint Today,
    uint Week,
    uint Month,
    uint Total
);
