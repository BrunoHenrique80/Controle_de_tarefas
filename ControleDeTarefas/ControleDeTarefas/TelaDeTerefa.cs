using BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace ControleDeTarefas
{
    public partial class TelaDeTerefa : Form
    {
        public TelaDeTerefa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (TeladeLogin frm = new TeladeLogin())
            {
                frm.ShowDialog();
                if (!frm.Logou)
                    Application.Exit();
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            TarefaBLL tarefaBLL = new TarefaBLL();
            tarefaBindingSource.DataSource = tarefaBLL.Buscar(textBoxBuscar.Text);
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            using (FormCadastroDeTarefas frm = new FormCadastroDeTarefas())
            {
                frm.ShowDialog();
            }
        }

        private void buttonSairDoLogin_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            using (TeladeLogin frm = new TeladeLogin())
            {
                frm.ShowDialog();
                if (!frm.Logou)
                    return;
            }
            this.Visible = !this.Visible;
        }

        private void buttonComentar_Click(object sender, EventArgs e)
        {
          
            using (TelaDeComentario frm = new TelaDeComentario())
            {
                frm.ShowDialog();
            }
            
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            //BindingSource tarefaBindingSource = new BindingSource();
            if (MessageBox.Show("Deseja realmente excluir este registro?", "Atenção", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            TarefaBLL tarefaBLL = new TarefaBLL();
           
            int id;

            id = Convert.ToInt32(((DataRowView)tarefaBindingSource.Current).Row["Id"]);
            tarefaBLL.Excluir(id);
            tarefaBindingSource.RemoveCurrent();
            MessageBox.Show("Registro excluido com secesso!");
        }

        private void tarefaBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (tarefaBindingSource.Count > 0)
            {
                ComentarioBLL comentarioBLL = new ComentarioBLL();
                int id_Tarefa = Convert.ToInt32(((DataRowView)tarefaBindingSource.Current).Row["Id"]);
                comentarioBindingSource.DataSource = comentarioBLL.Buscar(id_Tarefa);
            }
        }
    }
}
