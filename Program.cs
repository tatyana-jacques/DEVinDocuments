using DevInDocuments.Entities;
using DevInDocuments.Entities.Exceptions;


 Listas.ListaFuncionarios();


NotaFiscal nota = new NotaFiscal();
nota.CodigoDocumento = Guid.NewGuid().ToString();
nota.CadastrarDocumento(nota);








//Variáveis de conferência e inserção de dados

bool entrarMenuInicial = false;


//Interação com usuário
//Deve-se inserir uma id válida para validar funcionario. Id valida para teste: 12345678
ValidarFuncionario validarFuncionario = new ValidarFuncionario();

var identidadeFuncionario = validarFuncionario.ValidacaoFuncionario();
Console.WriteLine ($"A identidade do funcionário é: {identidadeFuncionario}");

//Menu inicial
while (entrarMenuInicial==false)
{
Console.WriteLine(@$"Insira o número da operação que deseja fazer:
1- Cadastrar documento;
2-Editar documento;
3-Listar documentos;
4-Visualizar total de documentos;
5-Sair do sistema.");

var escolhaMenuInicial = Console.ReadLine();

//Cadastrar documento
if (escolhaMenuInicial=="1"){
    Console.Write("Insira o nome do estabelecimento: ");
    var nomeEstabelecientoInserido = Console.ReadLine();
    entrarMenuInicial=true;

  
}

//Editar documento
if (escolhaMenuInicial=="2"){
    Console.WriteLine("Escolha o documento que deseja editar: ");



}

//Sair do programa
if (escolhaMenuInicial=="5"){
    break;
}

}








