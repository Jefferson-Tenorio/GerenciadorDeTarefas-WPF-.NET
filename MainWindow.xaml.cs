using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TreeAnalyzeTool.Entities;
using TreeAnalyzeTool.Interfaces;
using TreeAnalyzeTool.Repository;
using TreeAnalyzeTool.Services;

namespace TreeAnalyzeTool
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        GerenciadorDeTarefas gerenciador = new GerenciadorDeTarefas();
        Relatorio relatorio = new Relatorio();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_CriarTarefa_Click(object sender, RoutedEventArgs e)
        {
            if (Tb_novoDesc.Text != null && Tb_novoEstado.Text != null && Tb_novoTitulo != null && Tb_novoId != null)
            {
                
                gerenciador.AdicionarTarefa(new Tarefa(
              
                    Convert.ToInt32(Tb_novoId.Text),
                    Tb_novoTitulo.Text,
                    Tb_novoDesc.Text,
                    Tb_novoEstado.Text
                    ));
            }

            Tb_novoId.Clear();
            Tb_novoTitulo.Clear();
            Tb_novoDesc.Clear();
            Tb_novoEstado.Clear();

        }

        private void Btn_Buscar_Click(object sender, RoutedEventArgs e)
        {
            if (tb_BuscarTarefaPorID != null)
            {
                var selectTarefa = gerenciador.RetonarTarefa(Convert.ToInt32(tb_BuscarTarefaPorID.Text));
                if(selectTarefa != null)
                {
                    Lbl_Titulo.Content = selectTarefa.Titulo;
                    Lbl_Estado.Content = selectTarefa.Estado;
                    Lbl_Desc.Content = selectTarefa.Descricao;
                }
            }
        }

        private void Btn_GerarRelatorio_Click(object sender, RoutedEventArgs e)
        {   
            Lv_Relatorio.Items.Clear();

            //Melhorar esse codigo, isso parace uma gambiarra.
            //Antes a lista estava private e agora public sómente para percorrer ela.
            //E tive que converte para depois, porq não aceita ITarefa apenas IPrinter sendo que ITarefa não é IPrinter
            foreach (var tarefas in gerenciador.tarefas)
            {
                TarefaBase tarefaBase = (TarefaBase)tarefas;
                Lv_Relatorio.Items.Add(relatorio.GerarRelatorio(tarefaBase));
            }
        }

        private void Btn_Deletar_Click(object sender, RoutedEventArgs e)
        {
            gerenciador.DeletarTarefa(
                Convert.ToInt32(tb_BuscarTarefaPorID.Text));
        }

        private void Btn_Concluir_Click(object sender, RoutedEventArgs e)
        {
            gerenciador.ConcluirTarefa(Convert.ToInt32(tb_BuscarTarefaPorID.Text));
        }

        private void Btn_Pausar_Click(object sender, RoutedEventArgs e)
        {
            gerenciador.PausarTarefa(Convert.ToInt32(tb_BuscarTarefaPorID.Text));
        }
    }
}
