using GerenciamentoFinanceiro.Domain.Entities;
using GerenciamentoFinanceiro.Domain.Models;

namespace GerenciamentoFinanceiro.Domain.Interfeces
{
    public interface IEntradaRepository
    {
        List<Entrada> GetEntrada(FiltroHistoricoViewModel filtro);
        bool DeletaEntrada(int? Id);
        bool EditaEntrada(Entrada entrada);
        bool SalvaEntrada(Entrada entrada);
        Entrada GetEntradaPorId(int? id);
    }
}
