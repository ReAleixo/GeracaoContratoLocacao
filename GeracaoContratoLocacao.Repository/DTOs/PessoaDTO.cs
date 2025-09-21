using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeracaoContratoLocacao.Repository.DTOs
{
    [Table("People")]
    public class PessoaDTO
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Document { get; set; }
        public string RG { get; set; }
        public DateTime BirthDate { get; set; }
        public int MaritalStatusId { get; set; }
        public bool IsLessor { get; set; }
        public bool LogicalStatus { get; set; }
    }
}
