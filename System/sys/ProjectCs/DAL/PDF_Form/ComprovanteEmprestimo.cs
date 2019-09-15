using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using DALClients;
using DALItems;
using DALLoans;
using DALUsers;
/// <summary>
/// Classe para gerar um comprovante de empréstimo, precisa acessar todas as tabelas: usuários, clientes
/// empréstimo e itens, por isso faz referência a todas as classes DAL
/// </summary>
namespace ComprovanteEmprestimo
{
    /// <summary>
    /// Classe a ser chamada na geração
    /// </summary>
    public class GerarComprovantePdf
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
