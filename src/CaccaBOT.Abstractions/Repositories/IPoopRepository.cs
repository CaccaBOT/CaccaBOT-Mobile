using CaccaBOT.Abstractions.Primitives;

namespace CaccaBOT.Abstractions.Repositories;

public interface IPoopRepository
{
    ValueTask<LeaderboardEntry[]> GetLeaderboardAsync();
    ValueTask<LeaderboardEntry[]> GetMonthlyLeaderboardAsync(Month month);
    ValueTask<StatsSummary> GetGeneralStatsSummaryAsync();
    ValueTask<StatsSummary> GetUserStatsSummaryAsync(UserId id);
    ValueTask<MonthlyUserStatsSummary> GetMonthlyUserStatsSummaryAsync(UserId id, Month month);
    ValueTask<AutographedPoop[]> GetAllMonthlyPoopsAsync(Month month);
    ValueTask<Poop[]> GetUserPoopsAsync(UserId id);
    ValueTask<Poop[]> GetMonthlyUserPoopsAsync(UserId id, Month month);
}
