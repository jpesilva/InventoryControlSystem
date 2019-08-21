# InventoryControlSystem
	Repositório dos códigos utilizados na implementação do sistema de gerenciamento de estoque do grupo "Excel Lentes" do 2º sem de Análise de Desenvolvimento de Sistemas da Faculdade de Tecnologia de São José dos Campos.

# Site oficial do projeto
	https://sites.google.com/view/excellentes

# Desenvolvedores:
	Tobias da Silva Lino
		git: https://github.com/TobiasLino
		e-mail: tobias.lino@fatec.sp.gov.br
	Elieser de França Costa
		git: https://github.com/eliaeser
		e-mail: 
	Igor Sene Idalgo
		git: https://github.com/IgorS12
		e-mail: 
	João Victor Simão
		git: https://github.com/Joao1512
		e-mail: 
	João Pedro Esteves da Silva
		git: https://github.com/jpesilva
		e-mail: 

# Linguagem
	Todo o sistema foi implementado em linguagem C#, gerando, assim, um arquivo executável para Windows(utilizando a biblioteca Windows
	 Forms para gerar a interface gráfica).

# Sobre a organização de arquivos	
	- A pasta "Documentation" contém toda a documentação do projeto (Requisitos, desenhos de classe, desenhos originais das telas,
	 planilhas originais utilizadas, cronograma de atvidades);
	- A pasta "var" contém os arquivos modificados no decorrer do processamento (entradas de planilhas, formulários, banco de dados
	 de itens e de emprestantes);
	- A pasta "tmp" contém os arquivos temporários utilizados no sistema (as planilhas de entrada são armazenadas aqui enquanto o sistema
	 as processa e salva os dados dentro do banco, é uma pasta volátil, ou seja, os itenas são eliminados quando o sistema é fechado).
	- A pasta "root" contém os arquivos que só os administradores têm acesso (banco de dados de funcionários e de administradores);
	- A pasta "opt" contém os arquivos gerados pelo sistema (formulário .pdf, arquivo de banco de dados);
	- A pasta "sys" contém todas as soluções utilizadas na implementação do sistema;
		Separado em 4 Projetos:
			UI  - Corresponde as soluções de interface (Windows Forms);
			DAL - Corresponde as conexões com o banco de dados;
			DTO - Corresponde ao banco de dados em si, com suas respectivas tabelas e funções; e
			BLL - Corresponde aos cálculos e funções principais do sistema.
	- A pasta "bin" contém o arquivo executável do sistema.

	
