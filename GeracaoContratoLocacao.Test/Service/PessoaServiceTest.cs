using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Domain.ValueObjects;
using GeracaoContratoLocacao.Service.Services;
using GeracaoContratoLocacao.Test.Doubles;
using GeracaoContratoLocacao.Test.Helpers.Objects;

namespace GeracaoContratoLocacao.Test.Service
{
    public class PessoaServiceTest
    {
        PessoaService _pessoaService = new PessoaService(new PessoaRepositoryMock());

        [Fact]
        [Trait("PessoaService", "Buscar pessoa")]
        public async Task BuscarPessoaViaId_IdValido_DeveRetornarPessoaValida()
        {
            var pessoa = await _pessoaService.BuscarPessoaPorId(Guid.Parse("11111111-1111-1111-1111-111111111111"));
            Assert.NotNull(pessoa);
            Assert.Equal("11111111-1111-1111-1111-111111111111", pessoa.Id.ToString());
        }

        [Fact]
        [Trait("PessoaService", "Buscar pessoa")]
        public async Task BuscarPessoaViaIdConjuge_IdValido_DeveRetornarPessoaValida()
        {
            Pessoa pessoa = await _pessoaService.BuscarPessoaViaIdConjuge(Guid.Parse("22222222-2222-2222-2222-222222222222"));
            Assert.NotNull(pessoa);
            Assert.Equal("22222222-2222-2222-2222-222222222222", pessoa.Spouse.Id.ToString());
        }

        [Fact]
        [Trait("PessoaService", "Buscar pessoa")]
        public async Task BuscarPessoaViaId_IdInvalido_DeveLancarException()
        {
            await Assert.ThrowsAsync<ArgumentException>(() => _pessoaService.BuscarPessoaPorId(default));
        }

        [Fact]
        [Trait("PessoaService", "Buscar pessoa")]
        public async Task BuscarPessoaViaIdConjuge_IdInvalido_DeveLancarException()
        {
            await Assert.ThrowsAsync<ArgumentException>(() => _pessoaService.BuscarPessoaViaIdConjuge(default));
        }

        [Fact]
        [Trait("PessoaService", "Cadastrar pessoa")]
        public async Task CadastrarPessoa_PessoaValida_DeveRetornarGuid()
        {
            Pessoa pessoa = PessoaValida.PessoaValidaPadrao();
            pessoa.Id = await _pessoaService.CadastrarPessoa(pessoa);
            Assert.NotEqual(Guid.Empty, pessoa.Id);
        }

        [Fact]
        [Trait("PessoaService", "Cadastrar pessoa")]
        public async Task CadastrarPessoa_PessoaNula_DeveLancarException()
        {
            await Assert.ThrowsAsync<ArgumentNullException>(() => _pessoaService.CadastrarPessoa(null));
        }

        [Fact]
        [Trait("PessoaService", "Remover pessoa")]
        public async Task RemoverPessoa_PessoaValida_DeveRemoverComSucesso()
        {
            Pessoa pessoa = PessoaValida.PessoaValidaPadrao();
            await _pessoaService.RemoverPessoa(pessoa);
            // Assert
            // Se não lançar exceção, o teste passa
        }

        [Fact]
        [Trait("PessoaService", "Remover pessoa")]
        public async Task RemoverPessoa_PessoaNula_DeveLancarException()
        {
            await Assert.ThrowsAsync<ArgumentNullException>(() => _pessoaService.RemoverPessoa(null));
        }

        [Fact]
        [Trait("PessoaService", "Buscar pessoa")]
        public async Task BuscarPessoasPorFiltro_FiltroValido_DeveRetornarListaDePessoas()
        {
            var filtro = new Domain.ValueObjects.FiltroPessoas
            {
                Nome = "João"
            };
            IEnumerable<Pessoa> pessoas = await _pessoaService.BuscarPessoasPorFiltro(filtro);
            Assert.NotNull(pessoas);
        }

        [Fact]
        [Trait("PessoaService", "Buscar pessoa")]
        public async Task BuscarPessoasPorFiltro_FiltroNulo_DeveRetornarListaDePessoas()
        {
            IEnumerable<Pessoa> pessoas = await _pessoaService.BuscarPessoasPorFiltro(null);
            Assert.NotNull(pessoas);
        }

        [Fact]
        [Trait("PessoaService", "Buscar pessoa")]
        public async Task BuscarPessoaViaId_IdVazio_DeveLancarException()
        {
            await Assert.ThrowsAsync<ArgumentException>(() => _pessoaService.BuscarPessoaPorId(Guid.Empty));
        }

        [Fact]
        [Trait("PessoaService", "Buscar pessoa")]
        public async Task BuscarPessoaViaIdConjuge_IdVazio_DeveLancarException()
        {
            await Assert.ThrowsAsync<ArgumentException>(() => _pessoaService.BuscarPessoaViaIdConjuge(Guid.Empty));
        }

        [Fact]
        [Trait("PessoaService", "Cadastrar pessoa")]
        public async Task CadastrarPessoa_PessoaVazia_DeveLancarException()
        {
            await Assert.ThrowsAsync<ArgumentNullException>(() => _pessoaService.CadastrarPessoa(new Pessoa()));
        }

        [Fact]
        [Trait("PessoaService", "Remover pessoa")]
        public async Task RemoverPessoa_PessoaVazia_DeveLancarException()
        {
            await Assert.ThrowsAsync<ArgumentNullException>(() => _pessoaService.RemoverPessoa(new Pessoa()));
        }

        [Fact]
        [Trait("PessoaService", "Buscar pessoa")]
        public async Task BuscarPessoasPorFiltro_FiltroVazio_DeveRetornarListaDePessoas()
        {
            IEnumerable<Pessoa> pessoas = await _pessoaService.BuscarPessoasPorFiltro(new FiltroPessoas());
            Assert.NotNull(pessoas);
        }

        [Fact]
        [Trait("PessoaService", "Buscar pessoa")]
        public async Task BuscarPessoasPorFiltro_FiltroComCamposNulos_DeveRetornarException()
        {
            var filtro = new FiltroPessoas
            {
                Nome = null,
                Documento = null,
                ExibirConjuge = null,
                ExibirLocador = null,
                ExibirLocatario = null
            };
            await Assert.ThrowsAsync<ArgumentNullException>(() => _pessoaService.BuscarPessoasPorFiltro(filtro));
        }
    }
}
