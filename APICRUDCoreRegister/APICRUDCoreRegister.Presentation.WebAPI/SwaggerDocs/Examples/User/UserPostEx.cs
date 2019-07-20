using APICRUDCoreRegister.Presentation.WebAPI.Models.VM;
using Swashbuckle.AspNetCore.Examples;

namespace APICRUDCoreRegister.Presentation.WebAPI.SwaggerDocs.Examples.User
{
    public class UserPostEx : IExamplesProvider
    {
        public object GetExamples()
        {
            return new UserPostVM
            {
                idProfile = Models.Enum.EnumProfileVM.ADMIN,
                name = "User Test",
                email = "user@test.com",
                password = "1234",
                isActive = true
            };
        }
    }
}
