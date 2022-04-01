using GerenciamentoFinanceiro.Domain.Enum;

namespace GerenciamentoFinanceiro.Domain.Models
{
    public class TransacaoViewModel
    {
        public int? Id { get; set; }
        public DateTime? Data { get; set; }
        public string? Descricao { get; set; }
        public decimal? valor { get; set; }
        public TipoTransacao? TipoTransacao { get; set; }
    }
}
