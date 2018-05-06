using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tcc.DayHappy.Data.Contextos;
using Tcc.DayHappy.Data.Repositorios;
using Tcc.DayHappy.Dominio;
using Tcc.DayHappy.Dominio.Produtos;
using Tcc.DayHappy.Dominio.Usuario;

namespace Tcc.DayHappy.DI
{
    public class Bootsrap
    {
        public static void Configure(IServiceCollection services, string conection)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseMySql(conection));
            services.AddScoped(typeof(IRepository<Produto>), typeof(ProdutoRepository));
            services.AddScoped(typeof(IRepository<Funcionario>), typeof(FuncionarioRepository));
        }
    }
}
