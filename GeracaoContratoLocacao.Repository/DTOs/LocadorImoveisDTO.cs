using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeracaoContratoLocacao.Repository.DTOs
{
    [Table("Locador_Imoveis")]
    public class LocadorImoveisDTO
    {
        [Key]
        public Guid id_Locador_Imovel { get; set; }
        public Guid id_Imovel { get; set; }
        public Guid id_Locador { get; set; }
        public bool bt_Ativo { get; set; }
        public DateTime dt_Cadastro { get; set; }
        public DateTime dt_Alteracao { get; set; }
    }
}
