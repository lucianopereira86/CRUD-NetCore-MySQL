using APICRUDCoreRegister.Domain.Domain.Interfaces.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.Examples;
using APICRUDCoreRegister.Presentation.WebAPI.Models.VM;
using APICRUDCoreRegister.Presentation.WebAPI.SwaggerDocs.Examples.User;
using APICRUDCoreRegister.Domain.Domain.Models;
using APICRUDCoreRegister.Domain.Domain.Validations.User;
using System.Collections.Generic;
using APICRUDCoreRegister.Presentation.WebAPI.Models.Return;
using System.Threading.Tasks;

namespace APICRUDCoreRegister.Presentation.WebAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/User")]
    public class UserController : BaseController
    {
        private readonly IUserRepository repo;

        public UserController(IUserRepository r) : base()
        {
            repo = r;
        }

        [HttpPost]
        [SwaggerResponse(200)]
        [SwaggerResponse(400)]
        [SwaggerResponse(500)]
        [SwaggerRequestExample(typeof(UserPostVM), typeof(UserPostEx))]
        [SwaggerResponseExample(200, typeof(UserPostReturnEx))]
        public async Task<IActionResult> Post([FromBody] UserPostVM vm)
        {
            var _vm = Mapper.Map<User>(vm);
            return ExecMethod<User, UserReturnVM>(() => ValidateEntry(new UserPostValidation(repo), _vm), () => repo.Save(_vm));
        }

        [HttpPut]
        [SwaggerResponse(200)]
        [SwaggerResponse(400)]
        [SwaggerResponse(500)]
        [SwaggerRequestExample(typeof(UserPutVM), typeof(UserPutEx))]
        public async Task<IActionResult> Put([FromBody] UserPutVM vm)
        {
            var _vm = Mapper.Map<User>(vm);
            return ExecMethod(() => ValidateEntry(new UserPutValidation(repo), _vm), () => repo.Update(_vm));
        }

        [HttpGet]
        [SwaggerResponse(200)]
        [SwaggerResponse(400)]
        [SwaggerResponse(500)]
        [SwaggerResponseExample(200, typeof(UserGetReturnEx))]
        public async Task<IActionResult> Get([FromQuery] UserGetVM vm)
        {
            var _vm = Mapper.Map<UserGet>(vm);
            return ExecMethod<List<User>, List<UserReturnVM>>(null, () => repo.Get(_vm));
        }

        [HttpDelete]
        [SwaggerResponse(200)]
        [SwaggerResponse(400)]
        [SwaggerResponse(500)]
        public async Task<IActionResult> Delete([FromQuery] UserDeleteVM vm)
        {
            var _vm = Mapper.Map<User>(vm);
            return ExecMethod(() => ValidateEntry(new UserDeleteValidation(repo), _vm), () => repo.Delete(_vm));
        }
    }
}