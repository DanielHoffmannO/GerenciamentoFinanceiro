using GerenciamentoFinanceiro.Domain.Entities;
using GerenciamentoFinanceiro.Domain.Interfeces;
using GerenciamentoFinanceiro.Domain.Models;
using GerenciamentoFinanceiro.Persistence.Context;

namespace GerenciamentoFinanceiro.Persistence.Repositories
{
    public class SaidaRepository : ISaidaRepository
    {
        private readonly GestaoPessoalContext _context;
        public SaidaRepository(GestaoPessoalContext context)
        {
            _context = context;
        }

        public List<Saida> GetSaida(FiltroHistoricoViewModel filtro)
        {
            _context.lazyload = true;
            IQueryable<Saida> result = _context.Saida;

            if (filtro.DateInicio is not null)
                result.Where(X => X.DataSaida >= filtro.DateInicio);
            if (filtro.DateInicio is not null)
                result.Where(X => X.DataSaida <= filtro.DateFim);
            return result.ToList();
        }

        public Saida GetSaidaPorId(int? id)
        {
            _context.lazyload = true;
            return _context.Saida.Where(x => x.Id == id).FirstOrDefault();
        }

        public bool SalvaSaida(Saida saida)
        {
            try
            {
                _context.Saida.Add(saida);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeletaSaida(int? id)
        {
            try
            {
                _context.Saida.Remove(GetSaidaPorId(id));
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditaSaida(Saida saida)
        {
            try
            {
                _context.Saida.Update(saida);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
