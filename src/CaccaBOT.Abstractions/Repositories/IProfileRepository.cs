namespace CaccaBOT.Abstractions.Repositories;

public interface IProfileRepository
{
    User GetUserById(UserId id);
    User GetUserByName(string username);
}
