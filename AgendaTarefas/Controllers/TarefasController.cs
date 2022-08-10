//Aula3: Controller e Datas
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using AgendaTarefas.Models;

namespace AgendaTarefas.Controllers
{
    public class TarefasController : Controller
    {
        private readonly Contexto _contexto;

        public TarefasController(Contexto contexto)
        {
            _contexto = contexto;
        }
        public IActionResult Index()
        {
            return View(PegarDatas());
        }

        private List<DatasViewModel> PegarDatas()
        {
            DateTime dataAtual = DateTime.Now;
            DateTime dataLimite = DateTime.Now.AddDays(10);
            int qtdDias = 0;
            DatasViewModel data;
            List<DatasViewModel> listaDatas = new List<DatasViewModel>();

            while (dataAtual < dataLimite)
            {
                data = new DatasViewModel();
                data.Datas = dataAtual.ToShortDateString();
                data.Identificadores = "collapse" + dataAtual.ToShortDateString().Replace("/", "");
                listaDatas.Add(data);
                qtdDias = qtdDias + 1;
                dataAtual = DateTime.Now.AddDays(qtdDias);
            }

            return listaDatas;
        }

        //Criar Tarefas: Aula 6
        [HttpGet]
        public IActionResult CriarTarefa(string dataTarefa)
        {
            Tarefa tarefa = new Tarefa
            {
                Data = dataTarefa
            };

            return View(tarefa);
        }
        [HttpPost]
        public async Task<IActionResult> CriarTarefa(Tarefa tarefa)
        {
            if (ModelState.IsValid)
            {
                _contexto.Tarefas.Add(tarefa);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tarefa);
        }
        //Atualizar Tarefas: Aula 8
        [HttpGet]
        public async Task<IActionResult> AtualizarTarefa(int tarefaId)
        {
            Tarefa tarefa = await _contexto.Tarefas.FindAsync(tarefaId);

            if (tarefa == null)
                return NotFound();

            return View(tarefa);
        }

        [HttpPost]
        public async Task<IActionResult> AtualizarTarefa(Tarefa tarefa)
        {
            if (ModelState.IsValid)
            {
                _contexto.Update(tarefa);
                await _contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tarefa);
        }

        //Aula 10: Exclusão de Tarefas (Por ser exclusão ele só possui o Post!)
            //Observasão: A exclusão será feita em Ajax!
        [HttpPost]
        
        //Precisa do ID da tarefa (int tarefaId), para identificar qual tarefas queremos excluir! 
        public async Task<JsonResult> ExcluirTarefa(int tarefaId)
        {
            //Pegando a Tarefa
            Tarefa tarefa = await _contexto.Tarefas.FindAsync(tarefaId);
            //Removendo a Tarefa
            _contexto.Tarefas.Remove(tarefa);
            //Salvando a transação no banco de dados
            await _contexto.SaveChangesAsync();
            return Json(true);
        } 
    }
}
