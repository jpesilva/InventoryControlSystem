using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PDF
{
    // Classe principal de geração do Formulário
    class MainClass
    {
        static void Main(string[] args)
        {
            // Inicialização do documento
            Document doc = new Document(PageSize.A4); // criando e estipulando o tipo de folha
            doc.SetMargins(40, 40, 40, 80);
            doc.AddCreationDate();
            // caminho e nome do arquivo a ser salvo
            string caminho = @"/home/tobias/Git/InventoryControlSystem/System/opt/"+"PdfForm.pdf";
            PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(caminho, FileMode.Create));
            /*
             * abre
             */            
            doc.Open();

            // Fontes
            Font fonte_title = FontFactory.GetFont(BaseFont.HELVETICA, 12);
            Font fonte_text = FontFactory.GetFont(BaseFont.HELVETICA, 11);
            /*
             * Primeira parte
             * Dados da instituição
             */            
            // cria tabela
            PdfPTable table_top = new PdfPTable(2);
            // Logo
            Image logo = Image.GetInstance(@"/home/tobias/Git/InventoryControlSystem/System/sys/DAL/PDF_Form/Properties/logo/logo.png");
            // Células
            var cell1 = new PdfPCell();
            /*
             * Segunda Parte
             * Dados do Empréstimo
             */
            // cria tabela
            PdfPTable emp = new PdfPTable(7);
            // células
            var cell_Title = new PdfPCell();
            var cell_Emprestante = new PdfPCell();
            var cell_Cpf = new PdfPCell();
            var cell_Item = new PdfPCell();
            var cell_NPatrimonio = new PdfPCell();
            var cell_GrauDepreciacao = new PdfPCell();
            var cell_DataEmprestimo = new PdfPCell();
            var cell_DataDevolucao = new PdfPCell();
            var cell_msg_Devolucao = new PdfPCell();
            var cell_Funcionario = new PdfPCell();
            var cell_Registro = new PdfPCell();
            // dados
            Paragraph PTitle = new Paragraph("Dados do Empréstimo", fonte_title);
            Paragraph PEmprestante = new Paragraph("Emprestante :", fonte_text);
            Paragraph PCpf = new Paragraph("CPF :", fonte_text);
            Paragraph PItem = new Paragraph("Item :", fonte_text);
            Paragraph PNPatrimonio = new Paragraph("Nº do Patrimônio :", fonte_text);
            Paragraph PGrauDepreciacao = new Paragraph("Grau de Depreciação :", fonte_text);
            Paragraph PDataEmprestimo = new Paragraph("Data de Empréstimo :", fonte_text);
            Paragraph PDataDevolucao = new Paragraph("Data de Devolução :", fonte_text);
            Paragraph Pmsg_devolucao = new Paragraph("*Quinze dias depois do empréstimo", fonte_text);
            Paragraph PFuncionario = new Paragraph("Funcionário :", fonte_text);
            Paragraph PRegistro = new Paragraph("Registro :", fonte_text);
            /* Formatação */
            // Alinhamento
            PTitle.Alignment = Element.ALIGN_CENTER;
            PEmprestante.Alignment = Element.ALIGN_RIGHT;
            PCpf.Alignment = Element.ALIGN_RIGHT;
            PItem.Alignment = Element.ALIGN_RIGHT;
            PNPatrimonio.Alignment = Element.ALIGN_RIGHT;
            PGrauDepreciacao.Alignment = Element.ALIGN_RIGHT;
            PDataEmprestimo.Alignment = Element.ALIGN_RIGHT;
            PDataDevolucao.Alignment = Element.ALIGN_RIGHT;
            Pmsg_devolucao.Alignment = Element.ALIGN_RIGHT;
            PFuncionario.Alignment = Element.ALIGN_RIGHT;
            PRegistro.Alignment = Element.ALIGN_RIGHT;
            // Inserção de texto
            cell_Title.AddElement(PTitle);
            cell_Emprestante.AddElement(PEmprestante);
            cell_Cpf.AddElement(PCpf);
            cell_Item.AddElement(PItem);
            cell_NPatrimonio.AddElement(PNPatrimonio);
            cell_GrauDepreciacao.AddElement(PGrauDepreciacao);
            cell_DataEmprestimo.AddElement(PDataEmprestimo);
            cell_DataDevolucao.AddElement(PDataDevolucao);
            cell_msg_Devolucao.AddElement(Pmsg_devolucao);
            cell_Funcionario.AddElement(PFuncionario);
            cell_Registro.AddElement(PRegistro);
            // Inserção da celula na tabela
            emp.AddCell(cell_Title);
            emp.AddCell(cell_Item);

            // cria uma string vazia
            string dados = "";
            Paragraph paragrafo = new Paragraph(dados, new Font(Font.NORMAL, 14));
            // alinhamento
            paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
            // adicionando ao documento
            paragrafo.Add("TESTE");
            /*
             * inserções
             */
            doc.Add(logo);
            doc.Add(paragrafo);
            doc.Add(emp);
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
