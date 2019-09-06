using System;
using DTO;

/*
 * Classe de verificação de Login do usuário 
*/
namespace VerificaLogin {
	public class login {
		static void	Main(String[] args) {
			bool result, root_check;
			string user, sen;
            int n=0;
			lo l = new lo();
			result = false;
			root_check = false;
			Logado n2 = new Logado();
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
				n2.ok = result;
				if(n2.ok) {
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
	class lo {
		public string usuario = "tobias";
		public string senha = "1234";
		public string root = "root";
		public string senha_root = "12345";
	}
    class Logado {
		public bool ok = false;
	}
}