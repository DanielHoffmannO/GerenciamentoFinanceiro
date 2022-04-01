using GerenciamentoFinanceiro.Domain.Entities;
using GerenciamentoFinanceiro.Domain.Models;

namespace GerenciamentoFinanceiro.Domain.Interfeces
{
    public interface ISaidaRepository
    {
        List<Saida> GetSaida(FiltroHistoricoViewModel filtro);
        bool DeletaSaida(int? id);
        bool EditaSaida(Saida saida);
        bool SalvaSaida(Saida saida);
        Saida GetSaidaPorId(int? id);
    }
}
