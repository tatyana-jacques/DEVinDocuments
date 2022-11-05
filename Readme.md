<h1>DEVinDocuments</h1>
<p>Projeto 01 do Módulo 02 do curso DEVinHouse.</p>
<p>Turma EDP.</p>

<h2>Inicialização</h2>
<p> O projeto inicia-se com a função de autenticar funcionário. Há dois funcionários cadastrados para isso. O primeiro com ID 1234 e ou outro com ID 2345. Bastar entrar com uma dessas identidades para iniciar as opçoes de menu.</p>

<h2>Entidades de Classe</h2>
<h3>DevInDocuments</>
<p>É a classe pai, da qual derivam as classes NotaFiscal, LicencaFuncionamento e Contrato. Conta com o método CadastrarDocumento, que cadastra objetos das classes filhas na Lista estática de objetos DevInDocuments da classes estática Listas. Também conta com o método AlterarStatus, que recebe um objeto do tipo DevInDocuments e altera seu status e com os métodos Alterardocumento e ListarDocumento. O método AlterarStatus é utilizado diretamente pelas classes filhas de DevInDocuments, enquanto os métodos Listar Documento, Cadastrar Documento e Alterar Documento são sobrescritos em cada classe filha.<p>

<p>A escolha pela criaçao de construtor tanto na classe pai DevInDocuments, quanto nas classes filhas, deveu-se, principalmente à necessidade de tratamento de erro para casos de strings nulas. Dessa forma, não foi necessário a desabilitação do recurso de alerta de "Nullable" no documento DevInDocuments.csproj</p>

<p> Ao mesmo tempo, como no documento de instruções de escopo e elaboração do projeto era requisitado que os métodos Cadastrar Documentos, Listar Documentos, Alterar Documento e Alterar Status do Documento constassem já na classe pai e não fossem métodos estáticos, optei pela sobrecarga de construtor. Assim, no momento da instanciação de um objeto apenas para a chamada de algum de seus métodos, utilizo o contrutor apenas com os parâmetros de string tratados e no momento da criação de objetos por meio da interação do usuário pelo console, utilizo o coonstrutor com todos os parâmetros a serem definidos pelo usuário.</p>