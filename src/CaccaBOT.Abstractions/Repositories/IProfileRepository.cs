namespace CaccaBOT.Abstractions.Repositories;

public interface IProfileRepository
{
    ValueTask<User> GetUserByIdAsync(UserId id);
    ValueTask<User> GetUserByNameAsync(string username);
}
