using System;
using System.Collections.Generic;
using Trabalho.Api.Models;

namespace Trabalho.Api.Repositories{

    public interface IFundoCapitalRepository{

        void Adicionar(FundoCapital fundo);
        void Alterar(FundoCapital fundo);
        IEnumerable<FundoCapital> ListarFundos();
        FundoCapital obterPorId(Guid id);
        void RemoverFundo(FundoCapital fundo);
    }
}