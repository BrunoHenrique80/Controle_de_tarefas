using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class Comentario
    {
        private int id;
        private int id_Usuario;
        private int id_Tarefa;
        private string descricao;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Id_Usuario
        {
            get { return id_Usuario; }
            set { id_Usuario = value; }
        }


        public int Id_Tarefa
        {
            get { return id_Tarefa; }
            set { id_Tarefa = value; }
        }


        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

    }
}
