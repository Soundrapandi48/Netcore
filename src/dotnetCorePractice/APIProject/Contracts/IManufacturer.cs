using APIProject.Entities.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;

namespace APIProject.Contracts
{
    public interface IManufacturer
    {
        Task Create(ManufacturerDTO manufacturer);
        Task <IEnumerable<ManufacturerDTO>> GetAll();
        Task <ManufacturerDTO> Get(string Name);
        Task Update(string Name,ManufacturerDTO manufacturer);
        Task Delete(string Name);
        Task Save();
    }
}
