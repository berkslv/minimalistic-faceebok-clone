using Core.Entity.Abstract;

namespace Entity.Dtos
{
    public class UserDto : IGetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }
        public bool Status { get; set; }
        public int? UniversityId { get; set; }
        public int? FacultyId { get; set; }
        public int? DepartmentId { get; set; }
    }
}
