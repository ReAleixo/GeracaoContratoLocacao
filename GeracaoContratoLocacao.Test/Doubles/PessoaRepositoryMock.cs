using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Domain.ValueObjects;
using GeracaoContratoLocacao.Repository.Interfaces;
using GeracaoContratoLocacao.Test.Helpers.Objects;

namespace GeracaoContratoLocacao.Test.Doubles
{
    public class PessoaRepositoryMock : IPessoaRepository
    {
        public async Task AtualizarPessoa(Pessoa pessoa)
        {
            return;
        }

        public async Task<IEnumerable<Pessoa>> BuscarPessoasPorFiltro(FiltroPessoas filtro)
        {
            return PessoaValida.ListaPessoasValidas();
        }

        public async Task<Pessoa> BuscarPessoaViaId(Guid pessoaId)
        {
            return PessoaValida.PessoaValidaPorId(pessoaId);
        }

        public async Task<Pessoa> BuscarPessoaViaIdConjuge(Guid idConjgue)
        {
            return PessoaValida.PessoaValidaPorIdConjuge(idConjgue);
        }

        public async Task<Guid> CadastrarPessoa(Pessoa pessoa)
        {
            return Guid.NewGuid();
        }

        public async Task RemoverPessoa(Pessoa pessoa)
        {
            return;
        }
    }
}
