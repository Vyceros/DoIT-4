using AutoMapper;
using DoIT.Data.Model.DTO;
using DoIT.Data.Model;
using DoIT.Data;
using Microsoft.EntityFrameworkCore;
using System.Formats.Asn1;
using DoIT.Data;
using DoIT.Data.Model;
using DoIT.Data.Model.DTO;
using Microsoft.AspNetCore.Http.HttpResults;
using DoIT.Interfaces;

namespace DoIT.Services
{
    public class LectorService : ILectorService
    {
        // CreateLector, GetAllLector, GetLectorById, UpdateLector, DeleteLector

        private readonly ApplicationDbContext _db;
        /*private readonly IMapper _mapper;*/
        public LectorService(ApplicationDbContext db)
        {
            _db = db;
            /*_mapper = mapper;*/
        }

        public async Task<ICollection<Lector>> GetAll()
        {
            try
            {
                var lectors = await _db.Lectors.ToListAsync();
                return lectors;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /*public async Task<bool> CreateLector(LectorCreateDTO model)
        {
            try
            {
                var lector = _mapper.Map<Lector>(model);

                await _db.Lectors.AddAsync(lector);

                await _db.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteLector(int id)
        {
            try
            {
                var lector = await _db.Lectors.FirstOrDefaultAsync(x => x.Id == id);

                if (lector is null)
                    return false;

                _db.Remove(lector);

                await _db.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<Lector> GetById(int id)
        {
            try
            {
                var lector = _db.Lectors.Include(x => x.Students).FirstOrDefaultAsync(x => x.Id == id);
                return await lector;

            }
            catch (Exception)
            {

                return null;
            }
        }

        public async Task<bool> UpdateLector(int id,LectorCreateDTO lector)
        {
            var oldLector = await _db.Lectors.FindAsync(id);

            if(oldLector != null)
            {
                oldLector.Name = lector.Name;
                oldLector.Email = lector.Email;

                await _db.SaveChangesAsync();
            }

            return true;
        }*/
        
    }
}
