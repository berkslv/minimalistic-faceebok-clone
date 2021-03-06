using System.ComponentModel.DataAnnotations;
using Core.Constants;
using Core.Entity.Abstract;
using Core.Entity.Concrete;
using Entity.Concrete;
using FluentValidation;

namespace Entity.Dtos
{
    public class UserForRegisterDto : IDto
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Username { get; set; }

        public int? UniversityId { get; set; }

        public int? FacultyId { get; set; }

        public int? DepartmentId { get; set; }
        
        public string Role { get; set; } = Core.Entity.Concrete.Role.Student;
    }

    public class UserForRegisterDtoValidator : AbstractValidator<UserForRegisterDto>
    {
        public UserForRegisterDtoValidator()
        {
            RuleFor(x => x.Name).Length(1, 255).NotNull().WithName(Names.Name);

            RuleFor(x => x.Password).Length(6, 255).NotNull().WithName(Names.Password);

            RuleFor(x => x.Email).Length(1, 255).NotNull().EmailAddress().WithName(Names.Email);
            
            RuleFor(x => x.Username).Length(1, 255).NotNull().WithName(Names.Username);

            RuleFor(x => x.Role).Must(x => Role.RoleList.Contains(x)).WithName(Names.Role);

            When(x => x.Role == Core.Entity.Concrete.Role.Student, () => {
                RuleFor(x => x.UniversityId).NotNull().WithName(Names.University);

                RuleFor(x => x.FacultyId).NotNull().WithName(Names.Faculty);

                RuleFor(x => x.DepartmentId).NotNull().WithName(Names.Department);
            });

            When(x => x.Role != Core.Entity.Concrete.Role.Student, () => {
                RuleFor(x => x.UniversityId).Null().WithName(Names.University);

                RuleFor(x => x.FacultyId).Null().WithName(Names.Faculty);

                RuleFor(x => x.DepartmentId).Null().WithName(Names.Department);
            });
        }
    }


}