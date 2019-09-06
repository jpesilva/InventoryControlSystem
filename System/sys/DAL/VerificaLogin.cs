using System;
using DALUsers;

/// <summary>
/// Classe para certificar o login do usuário, deve manter seu valor
/// durante a execução do programa, quando desligado, seu valor se torna falso
/// </summary>
namespace VerificaLogin {
	/// <summary>
	/// Classe de verificação de Login
	/// </summary>
	public class login {
		static void	Main(String[] args) {
			bool result, root_check;
			string user, sen;
            int n=0;
			result = false;
			root_check = false;
			lo l = new lo();
			Logon n2 = new Logon();
            
			do {
				Console.Write("tobias login:");
				user = Console.ReadLine();
				Console.Write("password:");
				sen = Console.ReadLine();
				if(user==l.usuario) {
					if(sen==l.senha){
						result = true;
						root_check = false;
					}
				}
				if(user==l.root){
					if(sen==l.senha_root){
						result = true;
						root_check = true;
					}
				}
				n2.Logado = result;
				if(n2.Logado) {
					if(root_check) {
						Console.WriteLine('['+l.usuario+"@"+l.usuario+']'+"#");
						break;
					}
					else {
						Console.WriteLine('['+l.usuario+"@"+l.usuario+']'+"$");
						break;
					}
				}
				else {
					Console.WriteLine("Ocorreu um erro\nInsira denovo");
				}
				n++;
			} while(n<3);
			if(!result) {
				Console.WriteLine("Você errou três vezes :(");
			}
		}	
	}
	/// <summary>
	/// Classe de chamada de valores dentro do Banco
	/// </summary>
	class lo {
		public string usuario = "tobias";
		public string senha = "1234";
		public string root = "root";
		public string senha_root = "12345";
		
	}
	/// <summary>
	/// Boleano de login, 1 logado e 0 não
	/// </summary>
    class Logon {
		public bool Logado = false;
	}
}