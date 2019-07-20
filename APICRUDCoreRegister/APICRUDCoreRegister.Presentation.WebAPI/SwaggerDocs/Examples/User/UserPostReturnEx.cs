using APICRUDCoreRegister.Presentation.WebAPI.Models.Return;
using Swashbuckle.AspNetCore.Examples;

namespace APICRUDCoreRegister.Presentation.WebAPI.SwaggerDocs.Examples.User
{
    public class UserPostReturnEx : IExamplesProvider
    {
        public object GetExamples()
        {
            return new UserReturnVM
            {
                idUser = 1,
                idProfile = Models.Enum.EnumProfileVM.ADMIN,
                name = "User Test",
                email = "user@test.com",
                password = "1234",
                isActive = true
            };
        }
    }
}
