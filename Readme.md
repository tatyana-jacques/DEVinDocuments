<h1>DEVinDocuments</h1>
<p>Project developed during Senai's DEVinHouse (2022). </p>

<h2>Startup</h2>
<p> To start the application you must log in as an "employee". There are two employees registered for this. The first with ID 1234 and the other with ID 2345. Just enter one of these identities to start the menu options.</p>

<h2>Menus</h2>
<p> A layered menu was developed. After each user choice, new options are presented.</p>

<h2>Class Entities</h2>

<p>"DevInDocuments" is the parent class, from which derive the classes "NotaFiscal", "LicencaFuncionamento" and "Contrato". The parent class has the "CadastrarDocumento" method. This method registers objects of child classes in the "DevInDocuments" static list of the static class "Listas". It also has the "AlterarStatus" method, which receives an object of "DevInDocuments" type and changes its status, as well as the "Alterardocumento" and "ListarDocumento" methods. The "AlterarStatus" method is used directly by the "DevInDocuments" child classes, while the "ListarDocumento", "RegistrarDocumento" and "AlterarDocumento" methods are overridden in each child class.<p>

<p>The constructor containing all strings parameters was created for canceling the null string console warning without disabling the "Nullable" alert feature in the DevInDocuments.csproj. At the same time, the constructor's overload was made to make easier the inclusion of example objects in the static list in which the documents are registered.</p>

<h2>Registration List</h2>
<p>The user registers all documents in a single static list. The options for filtering and listing documents are shown in the "Listar Documentos" and "Relatórios" menu options.<p>