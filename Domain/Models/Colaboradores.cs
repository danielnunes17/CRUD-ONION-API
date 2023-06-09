using System.ComponentModel.DataAnnotations;

namespace CRUD_ONION_API.Domain.Models
{
    public class Colaboradores : BaseEntity
    {
        public int Codigo { get; set; }
        [Key]
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public string? Endereco { get; set; }
        public string? Empresa { get; set; }
    }
}
