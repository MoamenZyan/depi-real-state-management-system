using depi_real_state_management_system.Data;
using depi_real_state_management_system.Entities;
using Microsoft.AspNetCore.Mvc;

namespace depi_real_state_management_system.Controllers
{
    // كونترولر خاص بالستجيل وانشاء الحسابات وما يخص السيكيوريتي
    [Route("/api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public AuthController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public Task<IActionResult> RegisterUser([FromForm] ApplicationUser user)
        {
            if (!ModelState.IsValid)
            {
                // User registration logic
            }
            else
            {
                // If not valid logic
            }
            throw new NotImplementedException();
        }

        [HttpPost]
        public Task<IActionResult> Login([FromForm] UserCredentials userCredentials)
        {
            if (!ModelState.IsValid)
            {
                // User login logic
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
