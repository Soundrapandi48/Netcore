using APIProject.Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIProject.Contracts
{
    public interface IUserData
    {
        Task CreateUser(UserData userData);
        Task<IEnumerable<UserData>> GetAllUser();
        Task<UserData> GetUser(Guid Id);
        Task UpdateUser(Guid Id,UserData userData);
        Task DeleteUser(Guid Id);
        Task Save();
    }
}
