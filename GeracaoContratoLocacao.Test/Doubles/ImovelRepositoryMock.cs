using GeracaoContratoLocacao.Domain.Entities;
using GeracaoContratoLocacao.Repository.Interfaces;
using GeracaoContratoLocacao.Test.Helpers.Objects;

namespace GeracaoContratoLocacao.Test.Doubles
{
    public class ImovelRepositoryMock : IImovelRepository
    {
        public async Task<IEnumerable<Imovel>> BuscarImoveisPorProprietario(Guid idProprietario)
        {
            return new List<Imovel>
            {
                ImovelValido.ImovelValidoPorIdProprietario(idProprietario),
                ImovelValido.ImovelValidoPorIdProprietario(idProprietario),
                ImovelValido.ImovelValidoPorIdProprietario(idProprietario)
            };
        }

        public async Task<Imovel> BuscarImovelPorId(Guid idImovel)
        {
            return ImovelValido.ImovelValidoPorIdImovel(idImovel);
        }

        public async Task<IEnumerable<Imovel>> BuscarTodosImoveis()
        {
            return new List<Imovel>
            {
                ImovelValido.ImovelValidoPorIdImovel(Guid.NewGuid()),
                ImovelValido.ImovelValidoPorIdImovel(Guid.NewGuid()),
                ImovelValido.ImovelValidoPorIdImovel(Guid.NewGuid())
            };
        }

        public async Task<Guid> CadastrarNovoImovel(Imovel imovel)
        {
            return Guid.NewGuid();
        }

        public async Task RemoverImovel(Guid idImovel)
        {
            return;
        }

        public async Task SalvarAlteracoes(Imovel imovel)
        {
            return;
        }
    }
}
