using GerenciamentoFinanceiro.Domain.Enum;

namespace GerenciamentoFinanceiro.Domain.Models
{
    public class FiltroHistoricoViewModel
    {
        public DateTime? DateInicio { get; set; }
        public DateTime? DateFim { get; set; }
        public TipoTransacao? TipoTransacao { get; set; }
    }
}
