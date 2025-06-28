using GeracaoContratoLocacao.CrossCutting.Utils;
using GeracaoContratoLocacao.Domain.Utils;
using System.Diagnostics;

namespace GeracaoContratoLocacao.Presentation.ViewModels
{
    public class ContratoViewModel
    {
        public Guid Id { get; set; }
        public string NomeLocatario { get; set; }
        public string CPFLocatario { get; set; }
        public string RGLocatario { get; set; }
        public DateTime DataInicioContrato { get; set; }
        public int PrazoContrato { get; set; }
        public int NumeroCasa { get; set; }
        public decimal ValorAluguel { get; set; }

        public ContratoViewModel(
            string nomeLocatario,
            string cpfLocatario,
            string rgLocatario,
            string dataInicioContrato,
            string prazoContrato,
            int numeroCasa,
            string valorAluguel)
        {
            NomeLocatario = ValidaNome(nomeLocatario);
            CPFLocatario = ValidaCPF(cpfLocatario);
            RGLocatario = ValidaRG(rgLocatario);
            DataInicioContrato = ValidaDataInicioContrato(dataInicioContrato);
            PrazoContrato = ValidaPrazoContrato(prazoContrato);
            NumeroCasa = ValidaNumeroCasa(numeroCasa);
            ValorAluguel = ValidaValorAluguel(valorAluguel);
            Id = Guid.NewGuid();
        }

        private string ValidaNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome.Trim()))
            {
                throw new ArgumentException("O nome do locatário não pode ser vazio.");
            }
            if (nome.Length > 200)
            {
                throw new ArgumentException("O nome do locatário não pode ter mais de 200 caracteres.");
            }
            if (nome.Split(' ').Count() < 2)
            {
                throw new ArgumentException("O nome do locatário deve conter pelo menos um sobrenome.");
            }
            return nome;
        }

        private string ValidaCPF(string cpf)
        {
            Validacoes.ValidarCPF(cpf);
            return Formatacoes.FormatarCPF(cpf);
        }

        private string ValidaRG(string rg)
        {
            if (string.IsNullOrEmpty(rg))
            {
                throw new ArgumentException("O RG não pode ser nulo.");
            }
            if (rg.Length < 5)
            {
                throw new ArgumentException("RG inválido");
            }
            return rg;
        }

        private DateTime ValidaDataInicioContrato(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentException("A data de início do contrato não pode ser nula.");
            }

            if (data.Length < Lengths.Data)
            {
                throw new ArgumentException("A data de início do contrato é inválida.");
            }

            if (DateTime.TryParse(data, out DateTime dataInicio))
            {
                if (dataInicio < DateTime.Now.Date)
                {
                    throw new ArgumentException("A data de início do contrato não pode ser anterior à data atual.");
                }
                return dataInicio;
            }
            throw new ArgumentException("A data de início do contrato é inválida.");
        }

        private int ValidaPrazoContrato(string prazo)
        {
            if (string.IsNullOrEmpty(prazo))
            {
                throw new ArgumentException("O prazo do contrato não pode ser nulo.");
            }
            if (int.TryParse(prazo, out int prazoInt))
            {
                if (prazoInt <= 0)
                {
                    throw new ArgumentException("O prazo do contrato deve ser um número positivo.");
                }
                return prazoInt;
            }
            throw new ArgumentException("O prazo do contrato é inválido.");
        }

        private int ValidaNumeroCasa(int numeroCasa)
        {
            if (numeroCasa <= 0)
            {
                throw new ArgumentException("Casa inválida");
            }
            return numeroCasa;
        }

        private decimal ValidaValorAluguel(string valor)
        {
            if (string.IsNullOrEmpty(valor))
            {
                throw new ArgumentException("O valor do aluguel não pode ser nulo.");
            }
            if (decimal.TryParse(valor, out decimal valorDecimal))
            {
                if (valorDecimal <= decimal.Zero)
                {
                    throw new ArgumentException("O valor do aluguel deve ser um valor positivo.");
                }
                return valorDecimal;
            }
            throw new ArgumentException("O valor do aluguel é inválido.");
        }
    }
}
