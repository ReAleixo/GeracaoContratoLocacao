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
        private readonly IHouseController _controller;
        private readonly Guid _idImovel;
        private HouseViewModel viewModel;

        public CadastroImovel(IServiceProvider serviceProvider,
                              Guid idImovel = default)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _controller = _serviceProvider.GetRequiredService<IHouseController>();
            _idImovel = idImovel; 
        }

        private async void CadastroImovel_Load(object sender, EventArgs e)
        {
            cmbLocadorProprietario.DataSource = await _controller.ObterLocadores();
            cmbLocadorProprietario.DisplayMember = Enumeration.DisplayMemberAttribute;
            cmbLocadorProprietario.ValueMember = Enumeration.ValueMemberAttribute;

            if (_idImovel.Equals(default))
            {
                viewModel = new HouseViewModel();
                return;
            }

            viewModel = await _controller.GetHouseViewModelByHouseId(_idImovel);
            AlimentarCamposComViewModel();
        }

        private async void cmdSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                viewModel = AtualizaViewModel();
                await _controller.SaveChanges(viewModel);
                MessageBox.Show("Imóvel alterado com sucesso.", "INFORMATIVO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private HouseViewModel AtualizaViewModel()
        {
            HouseViewModel viewModelAtualizada = new HouseViewModel
            {
                HouseId = _idImovel,
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
