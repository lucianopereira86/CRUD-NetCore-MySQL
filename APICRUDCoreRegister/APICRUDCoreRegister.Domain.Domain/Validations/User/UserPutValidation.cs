using APICRUDCoreRegister.Domain.Domain.Interfaces.Repositories;
using FluentValidation;

namespace APICRUDCoreRegister.Domain.Domain.Validations.User
{
    public class UserPutValidation : UserPostValidation
    {
        public UserPutValidation(IUserRepository repo):base(repo)
        {
            RuleFor(x => x.idUser)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .GreaterThan(0)
                .Must(m => repo.Exist(x => x.idUser == m))
                .WithErrorCode("103").WithMessage("User not found").WithName("idUser");
        }
    }
}
