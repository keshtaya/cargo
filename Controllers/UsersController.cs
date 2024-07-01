using CargoCarApi.DTOs;
using CargoCarApi.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace CargoCarApi.Controllers
{
    [ApiController]
    [Route("users/[action]")]
    public class UsersController : ControllerBase
    {
        private readonly RegistrationService _registrationServices;

        public UsersController(RegistrationService registrationServices)
        {
            _registrationServices = registrationServices;
        }

        [HttpPost]
        [ActionName("register")]
        public async Task<IActionResult> Register(
            [FromForm] RegistrationForm registrationForm) {
            var createdUser = await _registrationServices
                .Register(registrationForm);

            return Ok(createdUser);
        }
    }
}
