
namespace ControleDeTarefas
{
    partial class TelaDeComentario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_TarefaLabel;
            System.Windows.Forms.Label id_UsuarioLabel;
            this.buttonInserirComentario = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSairDoComentario = new System.Windows.Forms.Button();
            this.comentarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.id_TarefaTextBox = new System.Windows.Forms.TextBox();
            this.id_UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            id_TarefaLabel = new System.Windows.Forms.Label();
            id_UsuarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.comentarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // id_TarefaLabel
            // 
            id_TarefaLabel.AutoSize = true;
            id_TarefaLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_TarefaLabel.ForeColor = System.Drawing.Color.White;
            id_TarefaLabel.Location = new System.Drawing.Point(182, 40);
            id_TarefaLabel.Name = "id_TarefaLabel";
            id_TarefaLabel.Size = new System.Drawing.Size(64, 15);
            id_TarefaLabel.TabIndex = 6;
            id_TarefaLabel.Text = "Id Tarefa";
            // 
            // id_UsuarioLabel
            // 
            id_UsuarioLabel.AutoSize = true;
            id_UsuarioLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_UsuarioLabel.ForeColor = System.Drawing.Color.White;
            id_UsuarioLabel.Location = new System.Drawing.Point(12, 40);
            id_UsuarioLabel.Name = "id_UsuarioLabel";
            id_UsuarioLabel.Size = new System.Drawing.Size(73, 15);
            id_UsuarioLabel.TabIndex = 8;
            id_UsuarioLabel.Text = "Id Usuario";
            // 
            // buttonInserirComentario
            // 
            this.buttonInserirComentario.BackColor = System.Drawing.Color.White;
            this.buttonInserirComentario.FlatAppearance.BorderSize = 0;
            this.buttonInserirComentario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInserirComentario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInserirComentario.ForeColor = System.Drawing.Color.Maroon;
            this.buttonInserirComentario.Location = new System.Drawing.Point(15, 313);
            this.buttonInserirComentario.Name = "buttonInserirComentario";
            this.buttonInserirComentario.Size = new System.Drawing.Size(75, 23);
            this.buttonInserirComentario.TabIndex = 1;
            this.buttonInserirComentario.Text = "Salvar";
            this.buttonInserirComentario.UseVisualStyleBackColor = false;
            this.buttonInserirComentario.Click += new System.EventHandler(this.buttonInserirComentario_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Comentário";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonSairDoComentario
            // 
            this.buttonSairDoComentario.BackColor = System.Drawing.Color.Transparent;
            this.buttonSairDoComentario.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.buttonSairDoComentario.FlatAppearance.BorderSize = 0;
            this.buttonSairDoComentario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSairDoComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSairDoComentario.ForeColor = System.Drawing.Color.Gray;
            this.buttonSairDoComentario.Image = global::ControleDeTarefas.Properties.Resources.sair;
            this.buttonSairDoComentario.Location = new System.Drawing.Point(537, 0);
            this.buttonSairDoComentario.Name = "buttonSairDoComentario";
            this.buttonSairDoComentario.Size = new System.Drawing.Size(38, 41);
            this.buttonSairDoComentario.TabIndex = 3;
            this.buttonSairDoComentario.UseVisualStyleBackColor = false;
            this.buttonSairDoComentario.UseWaitCursor = true;
            this.buttonSairDoComentario.Click += new System.EventHandler(this.buttonSairDoLogin_Click);
            // 
            // comentarioBindingSource
            // 
            this.comentarioBindingSource.DataSource = typeof(Model.Comentario);
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comentarioBindingSource, "Descricao", true));
            this.descricaoTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoTextBox.Location = new System.Drawing.Point(12, 129);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(560, 167);
            this.descricaoTextBox.TabIndex = 5;
            // 
            // id_TarefaTextBox
            // 
            this.id_TarefaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comentarioBindingSource, "Id_Tarefa", true));
            this.id_TarefaTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_TarefaTextBox.Location = new System.Drawing.Point(185, 58);
            this.id_TarefaTextBox.Name = "id_TarefaTextBox";
            this.id_TarefaTextBox.Size = new System.Drawing.Size(100, 23);
            this.id_TarefaTextBox.TabIndex = 7;
            // 
            // id_UsuarioTextBox
            // 
            this.id_UsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.comentarioBindingSource, "Id_Usuario", true));
            this.id_UsuarioTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_UsuarioTextBox.Location = new System.Drawing.Point(15, 58);
            this.id_UsuarioTextBox.Name = "id_UsuarioTextBox";
            this.id_UsuarioTextBox.Size = new System.Drawing.Size(100, 23);
            this.id_UsuarioTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(15, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Comentar";
            // 
            // TelaDeComentario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(579, 342);
            this.Controls.Add(this.label2);
            this.Controls.Add(id_UsuarioLabel);
            this.Controls.Add(this.id_UsuarioTextBox);
            this.Controls.Add(id_TarefaLabel);
            this.Controls.Add(this.id_TarefaTextBox);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.buttonSairDoComentario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInserirComentario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaDeComentario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaDeComentario";
            ((System.ComponentModel.ISupportInitialize)(this.comentarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonInserirComentario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSairDoComentario;
        private System.Windows.Forms.BindingSource comentarioBindingSource;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox id_TarefaTextBox;
        private System.Windows.Forms.TextBox id_UsuarioTextBox;
        private System.Windows.Forms.Label label2;
    }
}