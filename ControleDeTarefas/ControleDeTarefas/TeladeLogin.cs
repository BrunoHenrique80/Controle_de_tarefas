using BLL;
using Infra;
using System;
using System.Data;
using System.Windows.Forms;

namespace ControleDeTarefas
{
    public partial class TeladeLogin : Form
    {
        public bool Logou;
        public TeladeLogin()
        {
            InitializeComponent();
            Logou = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEntrada_Click(object sender, EventArgs e)
        {
            UsuarioBLL usuarioBLL = new UsuarioBLL();
            BindingSource usuarioBindingSource = new BindingSource();
            usuarioBindingSource.DataSource = usuarioBLL.Buscar(textBoxUsuario.Text);

            if (usuarioBindingSource.Count != 0)
            {
                string nome = ((DataRowView)usuarioBindingSource.Current).Row["Nome"].ToString();
                string senha = ((DataRowView)usuarioBindingSource.Current).Row["Senha"].ToString();

                if (nome == textBoxUsuario.Text && senha == textBoxSenha.Text)
                {
                    Logou = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha incorreta!");
                    textBoxSenha.Text = "";
                    textBoxSenha.Focus();
                }
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorreta!");
                textBoxSenha.Text = "";
                textBoxSenha.Focus();
            }
        }

        private void TeladeLogin_Load(object sender, EventArgs e)
        {

            Arquivo.GravarLog("Abriu a tela de login");

        }
    }
}        

