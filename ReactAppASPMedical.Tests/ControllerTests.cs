using ReactAppASPMedical.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


namespace ReactAppASPMedical.Tests
{
    public class ControllerTests
    {
        protected readonly ITestOutputHelper output;

        public ControllerTests(ITestOutputHelper output)
        {
            this.output = output;
        }

        public ApplicationDbContext CreateTestDbContext()
        {
            var dbPassword = Environment.GetEnvironmentVariable("DB_PASSWORD");

            // Set up configuration sources
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true) // Adjust the path as needed
                .AddEnvironmentVariables()
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");
            var defaultConnection = $"{connectionString}Password={dbPassword}";

            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseNpgsql(defaultConnection)
                .Options;

            var dbContext = new ApplicationDbContext(options);

            return dbContext;
        }
    }
}
