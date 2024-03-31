using AutoMapper;
using DoIT.Data;
using DoIT.Data.Model;
using DoIT.Data.Model.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System.Formats.Asn1;

namespace DoIT.Services
{
    public class StudentService
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public StudentService(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<bool> CreateStudent(StudentCreateDTO model)
        {
            try
            {
                var student = _mapper.Map<Student>(model);

                var lector = await _db.Lectors.FirstOrDefaultAsync(x=> x.Id == student.LectorId);

                if(lector != null)
                {
                    student.Lector = lector;
                }

                await _db.AddAsync(student);

                await _db.SaveChangesAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public async Task<ICollection<Student>> GetAll()
        {
            try
            {
                var students = await _db.Students.Include(x => x.Lector).ToListAsync();

                return students;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public async Task<bool> DeleteStudent(int id)
        {
            try
            {
                var student = await _db.Students.FirstOrDefaultAsync(x => x.Id == id);
                _db.Students.Remove(student);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<Student> GetStudentById(int id)
        {
            try
            {
                var student = await _db.Students.FirstOrDefaultAsync(x => x.Id == id);

                _db.Students.Remove(student);

                await _db.SaveChangesAsync();

                return student;
            }
            catch (Exception)
            {

                return null;
            }
        }
        public async Task<StudentCreateDTO> UpdateLector(int id, StudentCreateDTO student)
        {
            var oldStudent = await _db.Students.FindAsync(id);

            if (oldStudent != null)
            {
                oldStudent.Name = student.Name;
                oldStudent.Email = student.Email;
                oldStudent.LectorId = student.LectorId;
                oldStudent.Gpa = student.Gpa;

                await _db.SaveChangesAsync();
            }

            return null;
        }
    }

}
