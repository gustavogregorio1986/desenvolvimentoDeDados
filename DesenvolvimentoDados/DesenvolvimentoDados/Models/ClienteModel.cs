using System.ComponentModel.DataAnnotations;

namespace DesenvolvimentoDados.Models
{
    public class ClienteModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Informe o nome do cliente")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Informe o e-mail do Cliente")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe o Cpf do Cliente")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Informe a Profissão do Cliente")]
        public string Profissao { get; set; }
    }
}
