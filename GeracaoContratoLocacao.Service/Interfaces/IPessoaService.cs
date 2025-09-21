using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Domain.ValueObjects;

namespace GeracaoContratoLocacao.Service.Interfaces
{
    public interface IPessoaService
    {
        Task<IEnumerable<Pessoa>> BuscarPessoasPorFiltro(FiltroPessoas filtro);
        Task<Pessoa> BuscarPessoaViaId(Guid pessoaId);
        Task RemoverPessoa(Pessoa pessoa);
        Task CadastrarPessoa(Pessoa pessoa);
        Task<Pessoa> BuscarPessoaViaIdConjuge(Guid idConjuge);
    }
}
