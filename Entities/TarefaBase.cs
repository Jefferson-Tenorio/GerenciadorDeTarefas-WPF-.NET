using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeAnalyzeTool.Interfaces;

namespace TreeAnalyzeTool.Entities
{
    public abstract class TarefaBase : ITarefa, IPrinter
    {
        public TarefaBase() { }
        public TarefaBase(int IdTarefa, string titulo, string descricao, string estado)
        {
            this.Tarefaid = IdTarefa;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Estado = estado;
        }

        public int Tarefaid { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Estado { get; set; }

        public virtual void Concluir()
        {
            Estado = $"A tarefa {Titulo} foi concluida.";
        }

        public virtual void Iniciar()
        {
            Estado = $"A tarefa {Titulo} foi iniciada.";
        }

        public string MostrarDados()
        {
            return $"ID: {Tarefaid} | Titulo: {Titulo} | Descrição: {Descricao} | Estado: {Estado}";
        }

        public virtual void Pausar()
        {
            Estado = $"A tarefa {Titulo} foi pausada.";
        }
    }
}
