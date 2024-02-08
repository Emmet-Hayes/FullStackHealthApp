using ReactAppASPMedical.Server.Controllers;
using ReactAppASPMedical.Server.Models;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using ReactAppASPMedical.Tests;


namespace ReactAppASPMedical.Tests
{
    public class PatientControllerTests : ControllerTests
    {
        public PatientControllerTests(ITestOutputHelper output) : base(output) { }

        [Fact]
        public async Task TestGetPatientsAsync()
        {
            PatientController pc = new PatientController(CreateTestDbContext());
            var result = await pc.Get();

            foreach (Patient patient in result)
            {
                Assert.NotNull(patient);
                output.WriteLine("\nPatient Name: " + patient.Name + "\nEmail: " + patient.Email +
                                 "\nPhone Number: " + patient.PhoneNumber + "\nAge: " + patient.Age +
                                 "\nGender: " + patient.Gender + "\nAddress: " + patient.Address +
                                 "\nCity: " + patient.City + "\nRegion: " + patient.Region +
                                 "\nPostal Code: " + patient.PostalCode + "\nCountry: " + patient.Country +
                                 "\nBlood Type: " + patient.BloodType + "Allergies: " + patient.Allergies +
                                 "\nMedications: " + patient.Medications + "\nHistory: " + patient.History);
            }

            output.WriteLine("Number of Patients in Database: " + result.Count());
        }
    }
}