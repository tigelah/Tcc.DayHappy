using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Tcc.DayHappy.Data.Identity;
using Tcc.DayHappy.Dominio.Itinerarios;
using Tcc.DayHappy.Dominio.Orcamentos;
using Tcc.DayHappy.Dominio.Produtos;
using Tcc.DayHappy.Dominio.Usuario;

namespace Tcc.DayHappy.Data.Contextos
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<PessoaFisica> PessoasFisica { get; set; }
        public DbSet<PessoaJuridica> PessoasJuridica { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Orcamento> Orcamentos { get; set; }
        public DbSet<Itinerario> Itinerarios { get; set; }


    }


}
