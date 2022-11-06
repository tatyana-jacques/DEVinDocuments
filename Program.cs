using DevInDocuments.Entities.Validacoes;
using DevInDocuments.Entities.Static.Menus;

//Utilizar as identificações 1234 ou 2345 para validar o funcionario.

try{
var identidadeFuncionario = ValidarFuncionario.ValidacaoFuncionario();
MenuPrincipal.MenuInicial(identidadeFuncionario);
}

catch(Exception e)
{
    Console.WriteLine(e.Message);
}



