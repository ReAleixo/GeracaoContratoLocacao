using GeracaoContratoLocacao.Presentation.ViewModels;

namespace GeracaoContratoLocacao.Presentation.Interfaces
{
    public interface IPessoaController
    {
        Task<IEnumerable<PessoaViewModel>> BuscarPessoasPorFiltro(FiltrosPessoaViewModel filtros);
        Task<PessoaViewModel> BuscarPessoaViaId(Guid idPessoa);
        Task RemoverPessoa(Guid idPessoa);
        Task CadastrarPessoa(PessoaViewModel pessoaViewModel, PessoaViewModel? conjugViewModel = null);
        Task<PessoaViewModel> BuscarPessoaViaIdConjuge(Guid idConjuge);
        Task<PessoaViewModel> BuscarUltimaPessoaCadastrada();
    }
}
