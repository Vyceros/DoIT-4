using DoIT.Data.Model;
using DoIT.Data.Model.DTO;
using DoIT.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoIT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LectorController : ControllerBase
    {
        private readonly LectorService _lectorService;

        public LectorController(LectorService sectorService)
        {
            _lectorService = sectorService;
        }

        [HttpGet]
        public async Task<ICollection<Lector>> GetAll()
        {
            return await _lectorService.GetAll();
        }

        [HttpPost]
        public async Task<bool> Create(LectorCreateDTO model)
        {
            return await _lectorService.CreateLector(model);
        }

        [HttpDelete]
        public async Task<bool> DeleteLector(int id)
        {
            return await _lectorService.DeleteLector(id);
        }
        [HttpGet("{id}")]
        public async Task<Lector> GetLectorById(int id)
        {
            return await _lectorService.GetLectorById(id);
        }
        [HttpPut("{id}")]
        public async Task<LectorCreateDTO> EditLector(int id, LectorCreateDTO lector)
        {
            return await _lectorService.UpdateLector(id,lector);
            
        }
        /*[HttpPut("{id}")]
        public async Task<LectorCreateDTO> EditLector([FromRoute] int id, [FromBody] LectorCreateDTO lector)
        {
            return await _lectorService.UpdateLector(id, lector);

        }*/

    }
}
