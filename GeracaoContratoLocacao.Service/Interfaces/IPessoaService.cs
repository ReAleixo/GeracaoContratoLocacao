using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Domain.ValueObjects;

namespace GeracaoContratoLocacao.Service.Interfaces
{
    public interface IPessoaService
    {
        Task<IEnumerable<Pessoa>> BuscarPessoasPorFiltro(FiltroPessoas filtro);
        Task<Pessoa> BuscarPessoaPorId(Guid pessoaId);
        Task RemoverPessoa(Pessoa pessoa);
        Task<Guid> CadastrarPessoa(Pessoa pessoa);
        Task<Pessoa> BuscarPessoaViaIdConjuge(Guid idConjuge);
    }
}
