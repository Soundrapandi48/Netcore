using APIProject.Entities.DataTransferObjects;
using APIProject.Entities.Models;

namespace APIProject.Entities
{
    public class AutoMapping:AutoMapper.Profile
    {
        public AutoMapping()
        {
            CreateMap<ManuFacturer,ManufacturerDTO>().ReverseMap();
        }
    }
}
