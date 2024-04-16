using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeAnalyzeTool.Interfaces;

namespace TreeAnalyzeTool.Entities
{
    public class Tarefa : TarefaBase
    {
        public Tarefa() { }
        public Tarefa(int Tarefaid, string Titulo, string Descricao, string Estado) :base (Tarefaid, Titulo, Descricao, Estado)
        {

        }
    }
}
