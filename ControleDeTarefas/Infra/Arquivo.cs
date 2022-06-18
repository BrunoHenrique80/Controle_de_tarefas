using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    public static class Arquivo
    {
        public static void GravarTextoNoFinalDoArquivo(string _texto, string _arquivo)
        {
            FileStream fileStream = new FileStream(_arquivo, FileMode.Append);
            StreamWriter streamWriter = new StreamWriter(fileStream, Encoding.UTF8);

            streamWriter.WriteLine(_texto);
            streamWriter.Flush();
            streamWriter.Close();
            fileStream.Close();

        }
    }
}
