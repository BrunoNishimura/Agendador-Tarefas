using System.ComponentModel.DataAnnotations;

namespace AgendaTarefas.Models
{
    public class Tarefa
    {
        public int TarefaId { get; set; }

        //Criando DataAnnotations, eles servem para personalizar os nosso dados.
        //Exemplo: Se eu quiser que o nome seja obrigatório, devo colocar [Require]
        [Required(ErrorMessage = "{0} é obrigatório.")]
        [StringLength(25, ErrorMessage = "Use menos caracteres.")]
        public string Nome { get; set; }

        public string Data { get; set; }

        [Required(ErrorMessage = "{0} é obrigatório.")]
        [DataType(DataType.Time)]
        public string Horario { get; set; }
    }
}
