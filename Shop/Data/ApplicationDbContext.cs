using Microsoft.EntityFrameworkCore;

namespace Shop.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //database for production 
            optionsBuilder.UseSqlServer("Server=db38979.public.databaseasp.net; Database=db38979; User Id=db38979; Password=A!f8s4=HE#g2; Encrypt=True; TrustServerCertificate=True; MultipleActiveResultSets=True;");
            //database for dev
            //optionsBuilder.UseSqlServer("Data Source=.;Database=mvc_project;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
