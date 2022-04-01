using GerenciamentoFinanceiro.Application.Interface;
using GerenciamentoFinanceiro.Domain.Dto;
using GerenciamentoFinanceiro.Domain.Entities;
using GerenciamentoFinanceiro.Domain.Enum;
using GerenciamentoFinanceiro.Domain.Interfeces;
using GerenciamentoFinanceiro.Domain.Models;

namespace GerenciamentoFinanceiro.Application.ApplicationServices
{
    public class ConsultaService : IConsultaService
    {
        private readonly IEntradaRepository _entradaRepository;
        private readonly ISaidaRepository _saidaRepository;
        public ConsultaService(IEntradaRepository entradaRepository, 
                                   ISaidaRepository saidaRepository)
        {
            _entradaRepository = entradaRepository;
            _saidaRepository = saidaRepository;
        }

        public Histrorios VerHistorico(FiltroHistoricoViewModel filtro)
        {
            Histrorios histrorios = new();

            switch (filtro.TipoTransacao)
            {
                case TipoTransacao.Entrada:
                    histrorios.Entrada = VerHistoricoEntrada(filtro);
                    break;
                case TipoTransacao.Saida:
                    histrorios.Saida = VerHistoricoSaida(filtro);
                    break;
                default:
                    histrorios.Entrada = VerHistoricoEntrada(filtro);
                    histrorios.Saida = VerHistoricoSaida(filtro);
                    break;
            }
            return histrorios;
        }
        public List<Entrada> VerHistoricoEntrada(FiltroHistoricoViewModel filtro)
        {
            return _entradaRepository.GetEntrada(filtro);
        }
        public List<Saida> VerHistoricoSaida(FiltroHistoricoViewModel filtro)
        {
            return _saidaRepository.GetSaida(filtro);
        }
    }
}
