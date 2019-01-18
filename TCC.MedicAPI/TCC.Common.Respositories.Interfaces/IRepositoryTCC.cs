using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TCC.Common.Respositories.Interfaces
{
    public interface IRepositoryTCC<TDominio, TChave>
        where TDominio : class
    {
        List<TDominio> Selecionar(Expression<Func<TDominio, bool>> where = null);

        TDominio SelecionarPorID(TChave id);

        void Inserir (TDominio dominio);

        void Atualizar (TDominio dominio);

        void Excluir (TDominio dominio);

        void ExcluirPorID (TChave id);
    }
}
