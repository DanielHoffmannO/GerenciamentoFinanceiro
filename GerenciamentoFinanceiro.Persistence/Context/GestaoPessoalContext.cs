using GerenciamentoFinanceiro.Domain.Entities;
using GerenciamentoFinanceiro.Persistence.Mapping;
using Microsoft.EntityFrameworkCore;

namespace GerenciamentoFinanceiro.Persistence.Context
{
    public class GestaoPessoalContext : DbContext
    {
        public bool lazyload = false;

        public GestaoPessoalContext(DbContextOptions<GestaoPessoalContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new EntradaMapping());
            builder.ApplyConfiguration(new SaidaMapping());
            //builder.ApplyConfiguration(new SaldoMapping());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies(lazyload);

        }

        public DbSet<Entrada> Entrada { get; set; }
        public DbSet<Saida> Saida { get; set; }
        //public DbSet<Saldo> Saldo { get; set; }

    }
}
