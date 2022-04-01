
namespace GerenciamentoFinanceiro.Domain.Entities
{
    public  class Entrada
    {
        public int? Id { get; set; }
        public DateTime? DataEntrada { get; set; }
        public string? DescricaoEntrada { get; set; }
        public decimal? ValorEntrada { get; set; }
    }
}
