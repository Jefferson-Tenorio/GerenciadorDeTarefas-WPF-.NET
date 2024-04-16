using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreeAnalyzeTool.Interfaces;

namespace TreeAnalyzeTool.Services
{
    public class Relatorio
    {
        public string GerarRelatorio(IPrinter printer)
        {
            return printer.MostrarDados();
        }
    }
}
