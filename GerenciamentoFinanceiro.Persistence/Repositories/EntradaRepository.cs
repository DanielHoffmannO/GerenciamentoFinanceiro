using GerenciamentoFinanceiro.Domain.Entities;
using GerenciamentoFinanceiro.Domain.Interfeces;
using GerenciamentoFinanceiro.Domain.Models;
using GerenciamentoFinanceiro.Persistence.Context;

namespace GerenciamentoFinanceiro.Persistence.Repositories
{
    public class EntradaRepository : IEntradaRepository
    {
        private readonly GestaoPessoalContext _context;
        public EntradaRepository(GestaoPessoalContext context)
        {
            _context = context;
        }

        public Entrada GetEntradaPorId(int? id)
        {
            _context.lazyload = true;
            return _context.Entrada.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Entrada> GetEntrada(FiltroHistoricoViewModel filtro)
        {
            _context.lazyload = true;
            IQueryable<Entrada> result = _context.Entrada;

            if (filtro.DateInicio is not null)
                result.Where(X => X.DataEntrada >= filtro.DateInicio);
            if (filtro.DateInicio is not null)
                result.Where(X => X.DataEntrada <= filtro.DateFim);
            return result.ToList();
        }
        public bool SalvaEntrada(Entrada entrada)
        {
            try
            {
                _context.Entrada.Add(entrada);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeletaEntrada(int? id)
        {
            try
            {
                _context.Entrada.Remove(GetEntradaPorId(id));
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditaEntrada(Entrada entrada)
        {
            try
            {
                _context.Entrada.Update(entrada);
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