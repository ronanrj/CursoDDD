﻿using System.Collections.Generic;
using Manutencao.Solicitacao.Dominio.SolicitacoesDeManutencao;

namespace Manutencao.Solicitacao.Aplicacao.SolicitacoesDeManutencao
{
    public interface ISolicitacaoDeManutencaoRepositorio : IRepositorio<SolicitacaoDeManutencao>
    {
        IEnumerable<SolicitacaoDeManutencao> ObterPendentesDoTipo(TipoDeSolicitacaoDeManutencao apararGrama);
    }
}