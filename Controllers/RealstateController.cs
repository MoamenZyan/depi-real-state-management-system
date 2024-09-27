using depi_real_state_management_system.Data;
using depi_real_state_management_system.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace depi_real_state_management_system.Controllers
{
    // كونترولر خاص بالعقارات فقط
    [Route("api/[controller]")]
    [ApiController]
    public class RealstateController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public RealstateController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public Task<IActionResult> CreateRealState([FromForm] RealState realState)
        {
            if (!ModelState.IsValid)
            {
                // Real state creation logic
            }
            else
            {
                // If not valid logic
            }
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("{realStateId:int}")]
        public Task<IActionResult> DeleteRealState(int realStateId)
        {
            if (!ModelState.IsValid)
            {
                // Real state deletetion logic
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
