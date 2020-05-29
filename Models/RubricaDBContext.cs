using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
namespace PlayGround_Dependency_Injection.Models
{
    public class RubricaDBContext : DbContext
    {
        public DbSet <Contatto> contatti { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source =Desktop-EVE; Initial Catalog= RubricaCodeFirst; Integrated Security = True");
        }
    }
}