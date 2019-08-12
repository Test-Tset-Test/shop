using DataModels;

namespace Contracts.Data
{
    public interface IUserRepository
    {
        bool CreateUser(User data);
    }
}