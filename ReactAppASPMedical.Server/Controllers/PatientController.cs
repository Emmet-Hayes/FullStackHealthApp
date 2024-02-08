using ReactAppASPMedical.Server.Data;
using ReactAppASPMedical.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace ReactAppASPMedical.Server.Controllers
{
    [ApiController]
    [Route("/patients")]
    public class PatientController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PatientController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetPatient")]
        public async Task<IEnumerable<Patient>> Get()
        {
            return await _context.Patients.ToListAsync();
        }
    }
}
