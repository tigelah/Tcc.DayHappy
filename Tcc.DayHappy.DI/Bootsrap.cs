﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tcc.DayHappy.Data;
using Tcc.DayHappy.Data.Identity;
using Tcc.DayHappy.Data.Repositorios;
using Tcc.DayHappy.Dominio;
using Tcc.DayHappy.Dominio.Armazenar;
using Tcc.DayHappy.Dominio.ContaUsuarios;
using Tcc.DayHappy.Dominio.Eventos;
using Tcc.DayHappy.Dominio.FormaPagamento;
using Tcc.DayHappy.Dominio.Itinerarios;
using Tcc.DayHappy.Dominio.Orcamentos;
using Tcc.DayHappy.Dominio.Produtos;
using Tcc.DayHappy.Dominio.StatusEntregas;
using Tcc.DayHappy.Dominio.Storer;
using Tcc.DayHappy.Dominio.Usuario;

namespace Tcc.DayHappy.DI
{
    public class Bootsrap
    {
        public static void Configure(IServiceCollection services, string conection)
        {
            /*
            services.AddIdentity<ApplicationUser, IdentityRole>(config =>
            {

                config.Password.RequireDigit = false;
                config.Password.RequiredLength = 3;
                config.Password.RequireLowercase = false;
                config.Password.RequireNonAlphanumeric = false;
                config.Password.RequireUppercase = false;
                //config.Cookies.ApplicationCookie.LoginPath = "/Account/Login";
            })
            
                .AddDefaultTokenProviders();
            services.AddScoped(typeof(IRepository<Produto>),typeof(ProdutoRepository));
            services.AddScoped(typeof(IRepository<PessoaFisica>), typeof(PessoaFisicaRepository));
            services.AddScoped(typeof(IRepository<Contato>), typeof(ContatoRepository));
            services.AddScoped(typeof(PessoaFisicaRepository));
            services.AddScoped(typeof(PessoaJuridicaRepository));
            services.AddScoped(typeof(IRepository<PessoaJuridica>), typeof(PessoaJuridicaRepository));


            
             services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped(typeof(IRepository<Funcionario>),typeof(FuncionarioRepository));    
            services.AddScoped(typeof(IRepository<Orcamento>),typeof(OrcamentoRepository));
            services.AddScoped(typeof(IRepository<Pagamento>),typeof(PagamentoRepository));
            services.AddScoped(typeof(IRepository<Evento>), typeof(EventoRepository));
            services.AddScoped(typeof(IRepository<Itinerario>), typeof(ItinerarioRepository));
            services.AddScoped(typeof(IRepository<StatusEntrega>), typeof(StatusEntregaRepository));
            */
            services.AddScoped(typeof(IAuthentication), typeof(Authentication));
            services.AddScoped(typeof(IManager), typeof(Manager));
   //         services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
            services.AddScoped(typeof(ProdutoArmazenar));
            services.AddScoped(typeof(IRepository<Produto>), typeof(ProdutoRepository));
            services.AddScoped(typeof(PessoaFisica));
            services.AddScoped(typeof(PessoaFisicaArmazenar));
            services.AddScoped(typeof(PessoaJuridicaArmazenar));
            services.AddScoped(typeof(PessoaJuridica));
            services.AddScoped(typeof(IRepository<PessoaFisica>), typeof(PessoaFisicaRepository));
            services.AddScoped(typeof(IRepository<PessoaJuridica>), typeof(PessoaJuridicaRepository));
            services.AddScoped(typeof(IRepository<Contato>), typeof(ContatoRepository));
            services.AddScoped(typeof(PessoaFisicaRepository));
            services.AddScoped(typeof(PessoaJuridicaRepository));

            services.AddScoped(typeof(PessoaJuridica));
            services.AddScoped(typeof(PessoaJuridicaArmazenar));
           // services.AddScoped(typeof(FuncionarioArmazenar));
            services.AddScoped(typeof(OrcamentoArmazenar));
            services.AddScoped(typeof(ContatoArmazenar));
            services.AddScoped(typeof(ContatoRepository));



        }
    }
}
