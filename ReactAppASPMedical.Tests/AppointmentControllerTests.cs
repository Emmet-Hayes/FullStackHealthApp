using ReactAppASPMedical.Server.Controllers;
using ReactAppASPMedical.Server.Models;


namespace ReactAppASPMedical.Tests
{
    public class AppointmentControllerTests : ControllerTests
    {
        public AppointmentControllerTests(ITestOutputHelper output) : base(output) { }

        [Fact]
        public async Task TestGetAppointments()
        {
            AppointmentController pc = new AppointmentController(CreateTestDbContext());
            var result = await pc.Get();

            foreach (Appointment appointment in result)
            {
                Assert.NotNull(appointment);
                output.WriteLine("\nPatient Email: " + appointment.Patient + "\nDoctor: " + appointment.Doctor +
                                 "\nRoom:" + appointment.Room + "\nTime: " + appointment.Time +
                                 "\nNext: " + appointment.Next + "\nId: " + appointment.Id);
            }

            output.WriteLine("Number of Appointments in Database: " + result.Count());
        }
    }
}