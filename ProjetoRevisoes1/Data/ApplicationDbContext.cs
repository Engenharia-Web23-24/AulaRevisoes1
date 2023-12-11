using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjetoRevisoes1.Models;

namespace ProjetoRevisoes1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoRevisoes1.Models.BolsaInvestigacao> Bolsas { get; set; } = default!;
    }
}
