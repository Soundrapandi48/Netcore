using APIProject.Contracts;
using APIProject.Entities;
using APIProject.Entities.DataTransferObjects;
using APIProject.Entities.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIProject.Repository
{
    public class ManufacturerRepository : IManufacturer
    {
        private readonly IMapper _mapper;
        private readonly RepositoryContext _context;
        public ManufacturerRepository(IMapper mapper, RepositoryContext context)
        {
            this._mapper = mapper;
            this._context = context;
        }
        public async Task Create(ManufacturerDTO manufacturer)
        {
            var createMan = this._mapper.Map<ManuFacturer>(manufacturer);
            createMan.updtime = DateTime.Now;
            createMan.GuidId= Guid.NewGuid();
            await _context.AddAsync(createMan);
            await Save();
        }

        public async Task Delete(string Name)
        {
            ManuFacturer manufacturer = new ManuFacturer();
            manufacturer = await _context.ManuFacturers.FindAsync(Name);
            _context.Remove(manufacturer);
            await Save();
        }

        public async Task<ManufacturerDTO> Get(string Name)
        {
            ManuFacturer manufacturer = new ManuFacturer();
            manufacturer = await _context.ManuFacturers.FindAsync(Name);
            var result = _mapper.Map<ManufacturerDTO>(manufacturer);
            return result;
        }

        public async Task<IEnumerable<ManufacturerDTO>> GetAll()
        {
            List<ManuFacturer> manufacturer = new List<ManuFacturer>();
            manufacturer = await _context.ManuFacturers.ToListAsync();
            var result = _mapper.Map<List<ManufacturerDTO>>(manufacturer);
            return result;
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }

        public async Task Update(string name, ManufacturerDTO manufacturer)
        {
            ManuFacturer man = new ManuFacturer();
            man = await _context.ManuFacturers.FindAsync(name);
            var map=_mapper.Map<ManuFacturer>(man);
            map.Description = manufacturer.Description;
            map.upduser= manufacturer.upduser;
            map.updtime= DateTime.Now;
            _context.SaveChanges();
            await Save();
        }
    }
}
