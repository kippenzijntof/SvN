using Microsoft.EntityFrameworkCore;

namespace ConcreteSVN
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //Necessary to run the command "dotnet ef migrations add Initial" from cmd.exe
        public ApplicationDbContext()
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
            //optionsBuilder.UseSqlServer(@"Server=ROBERTO-PC\SQLEXPRESS;Database=Tools_NawV2;Trusted_Connection=True;");
            //optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=SVN;Trusted_Connection=True;MultipleActiveResultSets=true");
            optionsBuilder.UseSqlServer("Server=localhost;Database=svn;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public DbSet<ProductTable> Products { get; set; }
    }
}
