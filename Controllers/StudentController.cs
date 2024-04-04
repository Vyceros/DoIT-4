using DoIT.Data.Model;
using DoIT.Data.Model.DTO;
using DoIT.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoIT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentService _studentService;
        public StudentController(StudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost]
        public async Task<bool> Create(StudentCreateDTO model)
        {
            return await _studentService.CreateStudent(model);
        }
        [HttpGet]
        public async Task<ICollection<Student>> GetAll()
        {
            return await _studentService.GetAll();
        }
        [HttpDelete]
        public async Task<bool> Delete(int id)
        {
            return await _studentService.DeleteStudent(id);
        }

        [HttpGet("{id}")]
        public async Task<Student> GetStudentById(int id)
        {
            return await _studentService.GetStudentById(id);
        }
        [HttpPut]
        public async Task<StudentCreateDTO> UpdateStudent(int id,StudentCreateDTO student)
        {
            return await _studentService.UpdateLector(id, student);
        }

    }
}
