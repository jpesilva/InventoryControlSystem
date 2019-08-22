using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PDF
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Document doc = new Document(PageSize.A4); // criando e estipulando o tipo de folha
            doc.SetMargins(40, 40, 40, 80);
            doc.AddCreationDate();
            // caminho do arquivo e nome do arquivo
            string caminho = @"/home/tobias/" + "Teste.pdf";
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));

            // abre
            doc.Open();

            // cria uma string vazia
            string dados = "";
            Paragraph paragrafo = new Paragraph(dados, new Font(Font.NORMAL, 14));
            // alinhamento
            paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
            // adicionando ao documento
            paragrafo.Add("TESTE TESTE TESTE");
            doc.Add(paragrafo);
            // fechando para salvar
            doc.Close();
        }
    }
}
