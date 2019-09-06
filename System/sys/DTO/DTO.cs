using System;
using System.IO;
/// <summary>
/// DTO contém todas as tabelas do Banco de Dados, apenas comandos de conexão e criação de 
/// tabelas. Os comandos de inserção, seleção, edição e deletar estão localizadas em DAL
/// </summary>
namespace DTO
{
    /// <summary>
    /// Classe de conexão com o Banco de Dados
    /// </summary>
    private static SQLiteConnection DbConnection()
    {
        sqliteConnection = new SQLiteConnection("Data source=\\..\\Tables\\DB.sqlite; version=3;");
        sqliteConnection.Open();
        return sqliteConnection;
    }
    /// <summary>
    /// Classe que cria o Banco de Dados
    /// </summary>
    public static void SQLCreateBank()
    {
        try
        {
            SQLiteConnection.CreateFile(@"\\..\\Tables\\DB.sqlite");
        }
        catch
        {
            throw;
        }
    }
    /// <summary>
    /// Classe responsável por realizar a conexão com o Banco de Dados de clientes
    /// É pública, sendo chamada pela DAL
    /// </summary>
    public class DTOClients
    {
        public static void Main(string[] args)
        {
            
        }
    }
    /// <summary>
    /// Classe responsável por realizar a conexão com o Banco de Dados de Empréstimos
    /// É pública, sendo chamada pela DAL
    /// </summary>
    public class DTOLoans
    {
        public static void Main(string[] args)
        {
            
        }
    }
    /// <summary>
    /// Classe responsável por realizar a conexão com o Banco de Dados de itens
    /// É pública, sendo chamada pela DAL
    /// </summary>
    public class DTOITems
    {
        public static void Main(string[] args)
        {
            
        }
    }
    /// <summary>
    /// Classe responsável por realizar a conexão com o Banco de Dados de usuários
    /// É pública, sendo chamada pela DAL
    /// </summary>
    public class DTOUsers
    {
        public static void Main(string[] args)
        {
            try
            {
                using(var cmd = DbConnection().CreateCommand())
                {
                    cmd.CommandText = "CREATE TABLE IF NOT EXISTS USERS(usersID INT NOT NULL PRIMARY KEY, Registro NVARCHAR(50) NOT NULL,Usuario NVARCHAR(50) NOT NULL, Senha NVARCHAR(50) NOT NULL, Nivel BINARY NOT NULL)";
                    cmd.ExecuteNonQuery();
                }
            }
            catch(Exception ERRORUsersTable)
            {
                throw ERRORUsersTable;
            }
        }
    }
}
