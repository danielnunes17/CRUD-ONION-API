using System.ComponentModel.DataAnnotations;

namespace CRUD_ONION_API.Domain.Models
{
    public class Empresas : BaseEntity
    {
        public int Codigo { get; set; }
        [Key]
        public string CNPJ { get; set; }
        public string Nome { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public string? Endereco { get; set; }
        public bool? EhAtivo { get; set; }
    }
}
