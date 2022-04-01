using GerenciamentoFinanceiro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciamentoFinanceiro.Persistence.Mapping
{
    public class EntradaMapping : IEntityTypeConfiguration<Entrada>
    {
        public void Configure(EntityTypeBuilder<Entrada> builder)
        {
            builder.ToTable("Entrada");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.DataEntrada).HasColumnName("DataEntrada").HasColumnType("datetime");
            builder.Property(x => x.DescricaoEntrada).HasColumnName("DescricaoEntrada").HasColumnType("varchar").HasMaxLength(100);
            builder.Property(x => x.ValorEntrada).HasColumnName("ValorEntrada").HasColumnType("money");
        }
    }
}
