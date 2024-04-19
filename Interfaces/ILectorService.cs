using DoIT.Data.Model.DTO;
using DoIT.Data.Model;

namespace DoIT.Interfaces
{
    public interface ILectorService
    {
        Task<ICollection<Lector>> GetAll();
        /*       Task<Lector> GetById(int id);
               Task<bool> CreateLector(LectorCreateDTO model);
               Task<bool> UpdateLector(int id, LectorCreateDTO model);
               Task<bool> DeleteLector(int id);
           }*/
    }
}
