using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeAnalyzeTool.Entities;
using TreeAnalyzeTool.Interfaces;

namespace TreeAnalyzeTool.Repository
{
    public class GerenciadorDeTarefas
    {
        public List<ITarefa> tarefas = new List<ITarefa>();

        public void AdicionarTarefa(ITarefa tarefa)
        {
            tarefas.Add(tarefa);
        }

        public void DeletarTarefa(int TarefaId)
        {
            var tarefa = tarefas.Find(t =>(t as TarefaBase)?.Tarefaid == TarefaId);
            if(tarefa != null) tarefas.Remove(tarefa);
        }

        public void IniciarTarefa(int TarefaId)
        {
            var tarefa = tarefas.Find(t => (t as TarefaBase)?.Tarefaid == TarefaId);
            if(tarefa != null) tarefa.Iniciar();

        }

        public void PausarTarefa(int TarefaId)
        {
            var tarefa = tarefas.Find(t => (t as TarefaBase)?.Tarefaid == TarefaId);
            if (tarefa != null) tarefa.Pausar();
        }

        public void ConcluirTarefa(int TarefaId)
        {
            var tarefa = tarefas.Find(t =>(t as TarefaBase)?.Tarefaid == TarefaId);
            if (tarefa != null) tarefa.Concluir();
        }

        public ITarefa RetonarTarefa(int TarefaId)
        {
            var tarefa = tarefas.Find(t => (t as TarefaBase)?.Tarefaid == TarefaId);
            return tarefa;
        }

    }
}
