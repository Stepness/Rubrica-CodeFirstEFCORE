using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace PlayGround_Dependency_Injection.Models
{
    public class RubricaDBContext : DbContext
    {
        public DbSet <Contatto> contatti { get; set; }

    public RubricaDBContext (DbContextOptions options) : base(options){}

    }
}