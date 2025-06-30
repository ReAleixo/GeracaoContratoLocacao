using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeracaoContratoLocacao.Repository.DTOs
{
    [Table("Imoveis")]
    public class ImoveisDTO
    {
        [Key]
        public Guid id_Imovel { get; set; }
        public int nr_Comodos { get; set; }
        public decimal vl_Aluguel { get; set; }
        public bool bt_Locado { get; set; }
        public string ds_Rua { get; set; }
        public int nr_Numero { get; set; }
        public string ds_Complemento { get; set; }
        public string ds_Bairro { get; set; }
        public string ds_Cidade { get; set; }
        public string ds_Estado { get; set; }
        public string ds_CEP { get; set; }
        public bool bt_Ativo { get; set; }
        public DateTime dt_Cadastro { get; set; }
        public DateTime dt_Alteracao { get; set; }
    }
}
