using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Domain.ValueObjects;
using GeracaoContratoLocacao.Repository.Base.Interface;
using GeracaoContratoLocacao.Repository.DTOs;

namespace GeracaoContratoLocacao.Repository.Interfaces
{
    public interface IPessoaRepository : IRepositoryBase<PessoaDTO>
    {
        Task<IEnumerable<Pessoa>> BuscarPessoaPorFiltro(FiltroPessoas filtro);
        Task<Pessoa> BuscarPessoaViaId(Guid pessoaId);
        Task RemoverPessoa(Pessoa pessoa);
        Task CadastrarPessoa(Pessoa pessoa);
        Task AtualizarPessoa(Pessoa pessoa);
        Task<Pessoa> BuscarPessoaViaIdConjuge(Guid idConjgue);
        Task<Pessoa> BuscarUltimaPessoaCadastrada();
    }
}
