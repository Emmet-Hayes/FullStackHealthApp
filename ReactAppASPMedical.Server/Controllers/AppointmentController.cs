using ReactAppASPMedical.Server.Data;
using ReactAppASPMedical.Server.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace ReactAppASPMedical.Server.Controllers
{
    [ApiController]
    [Route("/appointments")]
    public class AppointmentController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AppointmentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetAppointment")]
        public async Task<IEnumerable<Appointment>> Get()
        {
            return await _context.Appointments.ToListAsync();
        }
    }
}
