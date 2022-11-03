using DevInDocuments.Entities;


Listas.ListaFuncionarios();

try{
    //Utilizar as identificações 1234 ou 2345 para validar o funcionario.
ValidarFuncionario validarFuncionario = new ValidarFuncionario();
var identidadeFuncionario = validarFuncionario.ValidacaoFuncionario();
MenuPrincipal.MenuInicial(identidadeFuncionario);
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}



