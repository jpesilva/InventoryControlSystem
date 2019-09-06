using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace PDF
{
    // Classe principal de geração do Formulário
    public class MainClass
    {
        static void Main(string[] args)
        {
            string oldFile = "Formulario.pdf";
            string newFile = "Comprovante.pdf";

            /*
             * Cria o PdfReader 
            */
            PdfReader reader = new PdfReader(oldFile);
            Rectangle size = reader.GetPageSizeRotation(1);
            Document document = new Document(size);

            /*
             * Fecha
             */
            doc.Close();
        }
    }
    // Classe para inserção dos dados do Empréstimo no Formulário
    public class Emprestimo
    {

    }
    // Classe para inserção dos dados do Emprestante no Formulário
    public class Emprestante
    {
        public String Nome;
        public String CPF;
        public String Birth;
        public String Email;
        public String Phone;
        public String Street;
        public String Number;
        public String City;
        public String Complement;
    }
    // Classe para inserção dos dados de item em empréstimo no Formulário
    public class Item
    {
        public int Quantidade;
        public String Descricao;
        public int N_patrimonio;
        public int Nota_fiscal;
        public String Fornecedor;
        public String Data_aquisicao;
        public String Localizacao;
        public char Grau_depreciacao;
    }
}
