using GeracaoContratoLocacao.Domain.Utils;

namespace GeracaoContratoLocacao.Presentation.ViewModels
{
    public class ContratoViewModel
    {
        public Guid Id { get; set; }
        public Guid IdLocador { get; set; }
        public Guid IdLocatario { get; set; }
        public Guid IdImovel { get; set; }
        public Guid IdModeloContrato { get; set; }
        public int Prazo { get; set; }
        public DateTime DataInicioContrato { get; set; }
        public DateTime DataGeracaoContrato { get; set; }

        public ContratoViewModel(
            string idLocador,
            string idLocatario,
            string idImovel,
            string idModeloContrato,
            string prazo,
            string dataInicioContrato,
            string dataGeracaoContrato)
        {
            IdLocador = ValidaGuid(idLocador, "O locador não foi selecionado");
            IdLocatario = ValidaGuid(idLocatario, "O locatário não foi selecionado");
            IdImovel = ValidaGuid(idImovel, "O imóvel não foi selecionado");
            IdModeloContrato = ValidaGuid(idModeloContrato, "O modelo de contrato não foi selecionado");
            Prazo = ValidaPrazo(prazo);
            DataInicioContrato = ValidaDateTime(dataInicioContrato, "data de início do contrato");
            DataGeracaoContrato = ValidaDateTime(dataGeracaoContrato, "data de geração do contrato");
            Id = Guid.NewGuid();
        }

        private Guid ValidaGuid(string id, string mensagemErro)
        {
            if (int.TryParse(id, out int intId)
                && intId > 0)
            {
                return Guid.Empty;
            }
            if (string.IsNullOrEmpty(id) 
                || !Guid.TryParse(id, out Guid guid)
                || guid.Equals(Guid.Empty))
            {
                throw new ArgumentException(mensagemErro);
            }
            return guid;
        }

        private DateTime ValidaDateTime(string data, string nomeCampo)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentException($"A {nomeCampo} não foi informada.");
            }

            if (data.Length < Lengths.Data)
            {
                throw new ArgumentException($"A {nomeCampo} é inválida.");
            }

            if (DateTime.TryParse(data, out DateTime dataInicio))
            {
                return dataInicio;
            }
            throw new ArgumentException($"A {nomeCampo} é inválida.");
        }

        private int ValidaPrazo(string prazo)
        {
            if (string.IsNullOrEmpty(prazo))
            {
                throw new ArgumentException("O prazo do contrato não foi informado.");
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
    }
}
