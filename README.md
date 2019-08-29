# InventoryControlSystem
	Repositório dos códigos utilizados na implementação do sistema de gerenciamento de estoque do
	 grupo "Excel Lentes" do 2º sem de Análise de Desenvolvimento de Sistemas da Faculdade de Tecnologia
	 de São José dos Campos.

## Site oficial do projeto
	https://sites.google.com/view/excellentes


## Linguagem
	Todo o sistema foi implementado em linguagem C#, gerando, assim, um arquivo executável para Windows(utilizando a
	 biblioteca Windows Forms para gerar a interface gráfica).

## Desenvolvedores:
	Tobias da Silva Lino
		git: https://github.com/TobiasLino
		e-mail: tobias.lino@fatec.sp.gov.br
	Elieser de França Costa
		git: https://github.com/eliaeser
		e-mail: elieser.fc93@gmail.com
	Igor Sene Idalgo
		git: https://github.com/IgorS12
		e-mail: igoridalgo@gmail.com			
	João Victor Simão
		git: https://github.com/Joao1512
		e-mail: jvictorsimao@hotmail.com
	João Pedro Esteves da Silva
		git: https://github.com/jpesilva
		e-mail: jp_edasilva@hotmail.com

# Motivação

### O problema das perdas
	O principal problema enfrentado pela instituição, e motivo pelo qual o projeto foi iniciado, é quanto à perda de itens, devido
	 a falta de informações quanto aos itens, falhas no controle e gerenciamento de empréstimos e de movimentação de itens e também
	 à dificuldade de busca dos dados (os registros de itens e empréstimos eram registrados em pastas muito desorganizadas, gerando,
	 assim, grande dificuldade para encontrar algo que se desejasse, ao procurar um empréstimo, por exemplo, o funcionário deveria
	 fazer uma busca por nome do emprestante, sendo que frequentemente esse nome era esquecido).

### Empréstimos em atraso
	Outro problema frequente na instituição era quanto ao atraso na devolução de itens de empréstimos, sendo estes programados para
	 quinze dias após o empréstimo.  Quando o emprestante atrasava, o contato com este era dificultoso, na maioria dos casos porque os
	 empréstimos eram armazenados de forma qualquer, sem organização e padronização.

### Excesso de papéis 
	Como dito antes, os registros de itens e empréstimos eram realizados em pastas, gerando um arquivo grande de papéis, ao contrário do que poderia ser feito caso houvesse um controle com planilhas ou Banco de Dados.

# Processamento
### Os arquivos de entrada
	Os dados de entrada do sistema correspondem a planilhas em formato .slx e .csv, onde os valores serão passados e registrados
	 dentro do Banco de Dados do sistema.

	Tais planilhas correspondem as informações (quantidade, nota fiscal, fornecedor, localização, data de aquisição, número
	 do patrimônio, descrição do bem, valor e grau de depreciação) dos itens em posse da instituição (bens), tanto os que estão
	 disponíveis para empréstimo, quanto os que não são emprestados (como mesas de reunião, cadeiras do restaurante etc.).

	De início, as planilhas podem estar desorganizadas, com possíveis itens duplicados ou com falta de informações, assim o
	 programa irá organizar os dados dentro de um Banco de Dados interno, verificando itens duplicados e informações incompletas
	 e gerenciando os itens que podem ser emprestados (os que já possuem empréstimo e os que estão livres para serem emprestados)
	 e os que não podem (itens de uso da instituição).

### Comunicação com o Banco de dados
### Estrutura de classes

### As Saídas do Programa
	O programa poderá gerar um arquivo de formulário em formato PDF, onde estarão as informações do empréstimo junto com os
	 dados do emprestante, podendo ser impresso ou salvo na máquina.

	O usuário cadastrado como administrador terá acesso ao arquivo de Banco de Dados local (.db), que poderá ser acessado por meio
	 de uma cópia do arquivo original (visualização) ou por meio do arquivo original, conforme o administrador necessitar (sendo
	 necessário acessar a pasta de arquivos internos), porém o recomendado é evitar fazer alterações diretamente no arquivo original.

	Quanto as planilhas de entrada, ao abri-las no programa, o sistema fará uma verificação dos dados dentro do Banco e ao salvar, o
	 sistema manterá esses dados apenas no Banco, não sendo modificadas as planilhas inseridas. Para evitar perda de dados e manter
	 um arquivo de backup, o programa manterá uma cópia da planilha original até o fechamento do sistema.

# Conclusão do Projeto
### Detalhes do Cronograma
### Finalização

## Agradecimentos
	Aos Professores Juliana Forin Pasquini Martinez (Engenharia de Software), Claudio Etelvino de Lima (Sistemas de Informação)
	 e Ana Cecilia Rodrigues Medeiros (Comunicação e Expressão), pelo auxílio no desenvolvimento do projeto.
	Ao professor Cícero pela elaboração do projeto e apresentação das necessidades.
	Aos desenvolvedores pelo empenho no desenvolvimento e estudo da linguagem.


	
