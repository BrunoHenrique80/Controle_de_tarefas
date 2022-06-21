using BLL;
using Model;
using System;
using System.Windows.Forms;

namespace ControleDeTarefas
{
    public partial class FormCadastroDeTarefas : Form
    {
        public FormCadastroDeTarefas()
        {
            InitializeComponent();
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            TarefaBLL tarefaBLL = new TarefaBLL();
            Tarefa tarefa = new Tarefa();
            tarefa.Descricao = descricaoTextBox.Text;
            tarefa.Estatus = estatusTextBox.Text;
            tarefa.Id_Usuario = 1;
            tarefaBLL.Inserir(tarefa);
            MessageBox.Show("Operação realizada com sucesso!");
            tarefaBindingSource.DataSource = typeof(Tarefa);
            tarefaBindingSource.AddNew();
           
        }

     

        private void FormCadastroDeTarefas_Load(object sender, EventArgs e)
        {

        }

        private void estatusTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSairDoLogin_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
