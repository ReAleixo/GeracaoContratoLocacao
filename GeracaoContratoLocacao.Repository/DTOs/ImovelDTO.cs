using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeracaoContratoLocacao.Repository.DTOs
{
    [Table("Imoveis")]
    public class ImovelDTO
    {
        [Key]
        public Guid id_Imovel { get; set; }
        public Guid id_Proprietario { get; set; }
        public int nr_Comodos { get; set; }
        public decimal mn_Aluguel { get; set; }
        public bool fl_Locado { get; set; }
        public string ds_Rua { get; set; }
        public int nr_Numero { get; set; }
        public string ds_Complemento { get; set; }
        public string ds_Bairro { get; set; }
        public string ds_Cidade { get; set; }
        public string ds_Estado { get; set; }
        public string ds_CEP { get; set; }
        public DateTime dt_Cadastro { get; set; }
        public DateTime dt_Alteracao { get; set; }
    }
}
