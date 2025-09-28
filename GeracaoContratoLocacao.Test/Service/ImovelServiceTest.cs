using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Service.Services;
using GeracaoContratoLocacao.Test.Doubles;
using GeracaoContratoLocacao.Test.Helpers.Objects;
using System.ComponentModel;

namespace GeracaoContratoLocacao.Test.Service
{
    public class ImovelServiceTest
    {
        ImovelService imovelService = new ImovelService(new ImovelRepositoryMock());

        [Fact]
        [Trait("ImovelService", "Cadastrar imovel")]
        public async void CadastrarNovoImovel_ImovelValido_CadastraComSucesso()
        {
            Imovel imovel = ImovelValido.ImovelValidoPadrao();

            Guid idNovoImovel = await imovelService.CadastrarNovoImovel(imovel);

            Assert.NotEqual(Guid.Empty, idNovoImovel);
        }

        [Fact]
        [Trait("ImovelService", "Cadastrar imovel")]
        public async void CadastrarNovoImovel_ImovelNulo_RetornaArgumentNullException()
        {
            Imovel imovel = null;

            await Assert.ThrowsAsync<ArgumentNullException>(() => imovelService.CadastrarNovoImovel(imovel));
        }

        [Fact]
        [Trait("ImovelService", "Cadastrar imovel")]
        public async void CadastrarNovoImovel_ImovelVazio_RetornaArgumentNullException()
        {
            Imovel imovel = new Imovel();

            await Assert.ThrowsAsync<ArgumentNullException>(() => imovelService.CadastrarNovoImovel(imovel));
        }

        [Fact]
        [Trait("ImovelService", "Remover imovel")]
        public async void RemoverImovel_IdImovelValido_RemoveComSucesso()
        {
            Guid idImovel = Guid.NewGuid();

            await imovelService.RemoverImovel(idImovel);

            // Assert
            // Se não lançar exceção, o teste passa
        }

        [Fact]
        [Trait("ImovelService", "Remover imovel")]
        public async void RemoverImovel_IdImovelInvalido_RetornaArgumentException()
        {
            Guid idImovel = default;

            await Assert.ThrowsAsync<ArgumentException>(() => imovelService.RemoverImovel(idImovel));
        }

        [Fact]
        [Trait("ImovelService", "Buscar imovel")]
        public async void BuscarTodosImoveis_RetornaListaDeImoveis()
        {
            IEnumerable<Imovel> imoveis = await imovelService.BuscarTodosImoveis();

            Assert.NotNull(imoveis);
            Assert.NotEmpty(imoveis);
        }

        [Fact]
        [Trait("ImovelService", "Buscar imovel")]
        public async void BuscarImovelPorId_IdImovelValido_RetornaImovel()
        {
            Guid idImovel = Guid.NewGuid();

            var imovel = await imovelService.BuscarImovelPorId(idImovel);

            Assert.NotNull(imovel);
            Assert.Equal(idImovel, imovel.Id);
        }

        [Fact]
        [Trait("ImovelService", "Buscar imovel")]
        public async void BuscarImovelPorId_IdImovelInvalido_RetornaArgumentException()
        {
            Guid idImovel = default;
            await Assert.ThrowsAsync<ArgumentException>(() => imovelService.BuscarImovelPorId(idImovel));
        }

        [Fact]
        [Trait("ImovelService", "Buscar imovel")]
        public async void BuscarImoveisPorProprietario_IdProprietarioValido_RetornaListaDeImoveis()
        {
            Guid idProprietario = Guid.NewGuid();
            var imoveis = await imovelService.BuscarImoveisPorProprietario(idProprietario);
            Assert.NotNull(imoveis);
            Assert.NotEmpty(imoveis);
            Assert.All(imoveis, imovel => Assert.Equal(idProprietario, imovel.Proprietario.Id));
        }

        [Theory]
        [InlineData(null)]
        [InlineData(default)]
        [Trait("ImovelService", "Buscar imovel")]
        public async void BuscarImoveisPorProprietario_IdProprietarioInvalido_RetornaArgumentException(Guid idProprietario)
        {
            await Assert.ThrowsAsync<ArgumentException>(() => imovelService.BuscarImoveisPorProprietario(idProprietario));
        }

        [Fact]
        [Trait("ImovelService", "Alterar imovel")]
        public async void AlterarImovel_ImovelValido_AlteraComSucesso()
        {
            Imovel imovel = ImovelValido.ImovelValidoPadrao();

            await imovelService.AlterarImovel(imovel);

            // Assert
            // Se não lançar exceção, o teste passa
        }

        [Fact]
        [Trait("ImovelService", "Alterar imovel")]
        public async void AlterarImovel_ImovelNulo_RetornaArgumentNullException()
        {
            Imovel imovel = null;
            await Assert.ThrowsAsync<ArgumentNullException>(() => imovelService.AlterarImovel(imovel));
        }

        [Fact]
        [Trait("ImovelService", "Alterar imovel")]
        public async void AlterarImovel_ImovelVazio_RetornaArgumentNullException()
        {
            Imovel imovel = new Imovel();
            await Assert.ThrowsAsync<ArgumentNullException>(() => imovelService.AlterarImovel(imovel));
        }
    }
}
