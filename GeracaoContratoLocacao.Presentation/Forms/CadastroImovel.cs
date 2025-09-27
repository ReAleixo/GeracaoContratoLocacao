using GeracaoContratoLocacao.Domain.Enums.Base;
using GeracaoContratoLocacao.Presentation.Interfaces;
using GeracaoContratoLocacao.Presentation.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System.Globalization;

namespace GeracaoContratoLocacao.Presentation.Forms
{
    public partial class CadastroImovel : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IImovelController _imovelController;
        private readonly IPessoaController _pessoaController;
        private readonly Guid _idImovel;
        private readonly Guid _idProprietario;
        private ImovelViewModel viewModel;

        public CadastroImovel(IServiceProvider serviceProvider,
                              Guid idImovel = default,
                              Guid idProprietario = default)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _imovelController = _serviceProvider.GetRequiredService<IImovelController>();
            _pessoaController = _serviceProvider.GetRequiredService<IPessoaController>();
            _idImovel = idImovel; 
            _idProprietario = idProprietario;
        }

        private async void CadastroImovel_Load(object sender, EventArgs e)
        {
            cmbLocadorProprietario.DataSource = (await _pessoaController.BuscarLocadores()).ToList();
            cmbLocadorProprietario.DisplayMember = nameof(PessoaViewModel.Name);
            cmbLocadorProprietario.ValueMember = nameof(PessoaViewModel.Id);

            if (!_idProprietario.Equals(default))
            {
                cmbLocadorProprietario.SelectedValue = _idProprietario;
                grbLocador.Enabled = false;
            }

            if (_idImovel.Equals(default))
            {
                viewModel = new ImovelViewModel();
                return;
            }

            viewModel = await _imovelController.GetHouseViewModelByHouseId(_idImovel);
            AlimentarCamposComViewModel();
        }

        private async void cmdSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                viewModel = AtualizaViewModel();

                if (viewModel.Id.Equals(default))
                {
                    viewModel.Id = await _imovelController.CadastrarNovoImovel(viewModel);
                    MessageBox.Show("Imóvel cadastrado com sucesso.", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    await _imovelController.SaveChanges(viewModel);
                    MessageBox.Show("Imóvel alterado com sucesso.", "Informativo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao alterar o imóvel:\n\n{ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AlimentarCamposComViewModel()
        {
            cmbLocadorProprietario.SelectedValue = viewModel.IdProprietario;
            txtNumeroComodos.Text = viewModel.NumeroComodos.ToString();
            txtValorAluguel.Text = viewModel.ValorAluguel.ToString("C", CultureInfo.CurrentCulture);
            chkLocado.Checked = viewModel.ImovelLocado;
            txtRua.Text = viewModel.Rua;
            txtNumero.Text = viewModel.Numero.ToString();
            txtComplemento.Text = viewModel.Complemento;
            txtBairro.Text = viewModel.Bairro;
            txtCidade.Text = viewModel.Cidade;
            txtEstado.Text = viewModel.Estado;
            txtCEP.Text = viewModel.CEP;
        }

        private ImovelViewModel AtualizaViewModel()
        {
            ImovelViewModel viewModelAtualizada = new ImovelViewModel
            {
                Id = _idImovel,
                IdProprietario = (Guid)cmbLocadorProprietario.SelectedValue,
                NumeroComodos = int.Parse(txtNumeroComodos.Text),
                ValorAluguel = decimal.Parse(txtValorAluguel.Text, NumberStyles.Currency, CultureInfo.CurrentCulture),
                ImovelLocado = chkLocado.Checked,
                Rua = txtRua.Text,
                Numero = int.Parse(txtNumero.Text),
                Complemento = txtComplemento.Text,
                Bairro = txtBairro.Text,
                Cidade = txtCidade.Text,
                Estado = txtEstado.Text,
                CEP = txtCEP.Text
            };

            return viewModelAtualizada;
        }

        private void cmdAdicionarLocador_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException("Funcionalidade de adicionar locador ainda não implementada.");
        }
    }
}
