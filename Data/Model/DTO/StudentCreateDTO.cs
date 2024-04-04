using System.ComponentModel.DataAnnotations.Schema;

namespace DoIT.Data.Model.DTO
{
    public class StudentCreateDTO
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public float Gpa { get; set; }
        public int LectorId { get; set; }

    }
}
