using GerenciamentoFinanceiro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciamentoFinanceiro.Persistence.Mapping
{
    public class SaidaMapping : IEntityTypeConfiguration<Saida>
    {
        public void Configure(EntityTypeBuilder<Saida> builder)
        {
            builder.ToTable("Saida");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.DataSaida).HasColumnName("DataSaida").HasColumnType("datetime");
            builder.Property(x => x.DescricaoSaida).HasColumnName("DescricaoSaida").HasColumnType("varchar").HasMaxLength(100);
            builder.Property(x => x.ValorSaida).HasColumnName("ValorSaida").HasColumnType("money");
        }
    }
}
