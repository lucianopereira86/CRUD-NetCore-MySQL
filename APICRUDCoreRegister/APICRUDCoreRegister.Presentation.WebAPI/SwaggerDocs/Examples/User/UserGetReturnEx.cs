using APICRUDCoreRegister.Presentation.WebAPI.Models.Return;
using Swashbuckle.AspNetCore.Examples;
using System.Collections.Generic;

namespace APICRUDCoreRegister.Presentation.WebAPI.SwaggerDocs.Examples.User
{
    public class UserGetReturnEx : IExamplesProvider
    {
        public object GetExamples()
        {
            return new List<UserReturnVM>
            {
                new UserReturnVM {
                    idUser = 1,
                    idProfile = Models.Enum.EnumProfileVM.ADMIN,
                    name = "User Test",
                    email = "user@test.com",
                    password = "1234",
                    isActive = true
                }
            };
        }
    }
}
