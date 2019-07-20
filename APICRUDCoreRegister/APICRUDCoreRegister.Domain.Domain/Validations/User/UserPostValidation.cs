using APICRUDCoreRegister.Domain.Domain.Interfaces.Repositories;
using FluentValidation;

namespace APICRUDCoreRegister.Domain.Domain.Validations.User
{
    public class UserPostValidation : AbstractValidator<Models.User>
    {
        public UserPostValidation(IUserRepository repo)
        {
            RuleFor(x => x)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .Must(m => repo.ExistsProfile(m.idProfile))
                .WithErrorCode("100").WithMessage("Profile not exists").WithName("idProfile")
                .Must(m => m.idUser > 0 || !repo.Exist(x => x.idUser != m.idUser && x.email.Equals(m.email)))
                .WithErrorCode("101").WithMessage("There is another user with this e-mail").WithName("email");
            RuleFor(x => x.name)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty();
            RuleFor(x => x.email)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty();
            RuleFor(x => x.password)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .NotEmpty();
        }
    }
}
