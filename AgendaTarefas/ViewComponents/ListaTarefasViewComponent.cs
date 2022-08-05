using AgendaTarefas.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AgendaTarefas.ViewComponents
{
    public class ListaTarefasViewComponent : ViewComponent
    {
        private readonly Contexto _contexto;

        //Criando o Construtor e inicializa-lo via injeção de dependências.
        public ListaTarefasViewComponent(Contexto contexto)
        {
            _contexto = contexto;
        }

        //IViewComponent é um método obrigatório.
        public async Task<IViewComponentResult> InvokeAsync(string data)
        {
            return View(await _contexto.Tarefas.OrderBy(t => t.Horario).Where(t => t.Data == data).ToListAsync());
        }

    }
}
