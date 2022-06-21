using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeTarefas
{
    public partial class TelaDeComentario : Form
    {
        public TelaDeComentario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSairDoLogin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonInserirComentario_Click(object sender, EventArgs e)
        {

            ComentarioBLL comentarioBLL = new ComentarioBLL();
            Comentario comentario = new Comentario();
            comentario.Id_Tarefa = 1;
            comentario.Id_Usuario = 1;
            comentario.Descricao = descricaoTextBox.Text;
            comentarioBLL.Inserir(comentario);
            MessageBox.Show("Operação realizada com sucesso!");
            comentarioBindingSource.DataSource = typeof(Comentario);
            comentarioBindingSource.AddNew();
            descricaoTextBox.Focus();
        }
    }
}
