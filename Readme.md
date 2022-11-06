<h1>DEVinDocuments</h1>
<p>Projeto 01 do Módulo 02 do curso DEVinHouse.</p>
<p>Turma EDP.</p>

<h2>Inicialização</h2>
<p> O projeto inicia-se com a função de autenticar funcionário. Há dois funcionários cadastrados para isso. O primeiro com ID 1234 e ou outro com ID 2345. Bastar entrar com uma dessas identidades para iniciar as opçoes de menu.</p>

<h2>Menus</h2>
<p> Foi desenvolvido um Menu em camadas. Algumas opções são apresentadas inicialmente e após a escolha do usuário outras opções são apresentadas.</p>

<h2>Entidades de Classe</h2>

<p>DevInDocuments é a classe pai, da qual derivam as classes NotaFiscal, LicencaFuncionamento e Contrato. Conta com o método CadastrarDocumento, que cadastra objetos das classes filhas na Lista estática de objetos DevInDocuments da classes estática Listas. Também conta com o método AlterarStatus, que recebe um objeto do tipo DevInDocuments e altera seu status e com os métodos Alterardocumento e ListarDocumento. O método AlterarStatus é utilizado diretamente pelas classes filhas de DevInDocuments, enquanto os métodos Listar Documento, Cadastrar Documento e Alterar Documento são sobrescritos em cada classe filha.<p>

<p>A escolha pela criaçao do contrutor contendo todos os parâmetros de string deveu-se ao intuito de cancelar o aviso sobre a possibilidade de string nula sem a desabilitação do recurso de alerta de "Nullable" no documento DevInDocuments.csproj</p>

<p> Ao mesmo tempo, a sobrecarga de construtor foi criada para facilitar a implementação dos objetos criados como exemplo na Lista estática na qual são cadastrados os documentos.</p>

<h2>Lista de Cadastro</h2>
<p>Foi criada uma lista estática única na qual o usuário cadastra todos os documentos. Nas opções Listar Documentos e Relatórios são apresentadas as opções de filtragem e listagem de documentos.<p>