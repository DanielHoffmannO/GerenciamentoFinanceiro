using GerenciamentoFinanceiro.Application.Interface;
using GerenciamentoFinanceiro.Domain.Entities;
using GerenciamentoFinanceiro.Domain.Enum;
using GerenciamentoFinanceiro.Domain.Interfeces;
using GerenciamentoFinanceiro.Domain.Models;

namespace GerenciamentoFinanceiro.Application.ApplicationServices
{
    internal class AlteraTabelaService : IAlteraTabelaService
    {
        private readonly IEntradaRepository _entradaRepository;
        private readonly ISaidaRepository _saidaRepository;
        public AlteraTabelaService(IEntradaRepository entradaRepository,
                           ISaidaRepository saidaRepository)
        {
            _entradaRepository = entradaRepository;
            _saidaRepository = saidaRepository;
        }

        public string Deleta(TransacaoViewModel transacao)
        {
            bool retorno = false;

            if (transacao.TipoTransacao.Equals(TipoTransacao.Entrada))
                retorno = _entradaRepository.DeletaEntrada(transacao.Id);
            else
                retorno = _saidaRepository.DeletaSaida(transacao.Id);

            return retorno ? "Sucesso" : "Erro"; 
        }

        public string Salva(TransacaoViewModel transacao)
        {
            bool retorno = false;

            if (transacao.TipoTransacao.Equals(TipoTransacao.Entrada))
            {
                Entrada entrada = new()
                {
                    DataEntrada = DateTime.Now,
                    DescricaoEntrada = transacao.Descricao,
                    ValorEntrada = transacao.valor,
                };
                _entradaRepository.SalvaEntrada(entrada);
            }
            else
            {
                Saida saida = new()
                {
                    DataSaida = DateTime.Now,
                    DescricaoSaida = transacao.Descricao,
                    ValorSaida = transacao.valor,
                };
                _saidaRepository.SalvaSaida(saida);
            }

            return retorno ? "Sucesso" : "Erro";
        }

        public string Altera(TransacaoViewModel transacao)
        {
            bool retorno = false;

            if (transacao.TipoTransacao.Equals(TipoTransacao.Entrada))
            {
                Entrada entrada = new()
                {
                    Id = transacao.Id,
                    DataEntrada = DateTime.Now,
                    DescricaoEntrada = transacao.Descricao,
                    ValorEntrada = transacao.valor,
                };
                _entradaRepository.EditaEntrada(entrada);
            }
            else
            {
                Saida saida = new()
                {
                    Id = transacao.Id,
                    DataSaida = DateTime.Now,
                    DescricaoSaida = transacao.Descricao,
                    ValorSaida = transacao.valor,
                };
                _saidaRepository.EditaSaida(saida);
            }

            return retorno ? "Sucesso" : "Erro";
        }
    }
}


