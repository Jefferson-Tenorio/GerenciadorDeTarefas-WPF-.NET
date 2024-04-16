using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeAnalyzeTool.Interfaces
{
    public interface ITarefa
    {
        int Tarefaid { get; set; }
        string Titulo { get; set; }
        string Descricao { get; set; }
        string Estado { get; set; }

        void Iniciar();
        void Pausar();
        void Concluir();
    }
}
