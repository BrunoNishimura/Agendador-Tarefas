using Microsoft.EntityFrameworkCore;

namespace AgendaTarefas.Models
{
    //Herdar de DbContext usando o Microsoft.EntityFrameworkCore
    public class Contexto : DbContext
    {
        public DbSet<Tarefa> Tarefas { get; set; }

        //Criando um construtor, o contexto. E passando ele pelo construtor `base` como opcoes.
        public Contexto(DbContextOptions<Contexto> opcoes):base(opcoes)
        {
            //Configuração da ConnectionString em appsettings.json, este mostra a Visual Studio qual o nome do nosso banco de dados.
            
            
        }
    }
}
