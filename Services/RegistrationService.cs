using CargoCarApi.Data;
using CargoCarApi.DTOs;
using ECommerceApi.Models;

namespace CargoCarApi.Services
{
    public class RegistrationService
    {
        private readonly PostgreSqlDbContext _dbContext;

        public RegistrationService(PostgreSqlDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<User> Register(RegistrationForm registrationForm)
        {
            var newUser = new User {
                Name = registrationForm.Name,
                Email = registrationForm.Email,
                Phone = registrationForm.Phone,
                ImageUrl = registrationForm.ImageUrl,
                Password = registrationForm.Password,
            };

           var result = await _dbContext.Users.AddAsync(newUser);
            _dbContext.SaveChanges();

            return result.Entity;
        }
    }
}
