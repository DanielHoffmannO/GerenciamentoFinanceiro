
namespace GerenciamentoFinanceiro.Domain.Entities
{
    public class Saida
    {
        public int? Id { get; set; }
        public DateTime? DataSaida { get; set; }
        public string? DescricaoSaida { get; set; }
        public decimal? ValorSaida { get; set; }
    }
}
