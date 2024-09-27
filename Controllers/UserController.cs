using depi_real_state_management_system.Data;
using depi_real_state_management_system.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace depi_real_state_management_system.Controllers
{
    // كونترولر خاص باليوزر فقط
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("{userId:int}")]
        public Task<IActionResult> GetUserInfo(int userId)
        {
            if (!ModelState.IsValid)
            {
                // Getting user info logic
            }
            else
            {
                // If not valid logic
            }
            throw new NotImplementedException();
        }

        // Add more
    }
}
