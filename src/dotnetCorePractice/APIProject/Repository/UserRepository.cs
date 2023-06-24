using APIProject.Contracts;
using APIProject.Entities;
using APIProject.Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIProject.Repository
{
    public class UserRepository : IUserData
    {
        private readonly RepositoryContext _context;
        public UserRepository(RepositoryContext repository)
        {
            _context = repository;
        }
        public async Task CreateUser(UserData userData)
        {
            await _context.UserDetails.AddAsync(userData);
            await Save();
        }

        public Task DeleteUser(Guid Id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserData>> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public Task<UserData> GetUser(Guid Id)
        {
            throw new NotImplementedException();
        }

        public async Task Save()
        {
             await _context.SaveChangesAsync();
        }

        public Task UpdateUser(Guid Id, UserData userData)
        {
            throw new NotImplementedException();
        }
    }
}
