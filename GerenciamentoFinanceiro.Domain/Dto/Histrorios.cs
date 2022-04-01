using GerenciamentoFinanceiro.Domain.Entities;

namespace GerenciamentoFinanceiro.Domain.Dto
{
    public class Histrorios
    {
        public List<Entrada>? Entrada { get; set; }
        public List<Saida>? Saida { get; set; }
}
}
