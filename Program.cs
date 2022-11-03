using DevInDocuments.Entities;



Listas.ListaFuncionarios();

try{
ValidarFuncionario validarFuncionario = new ValidarFuncionario();
var identidadeFuncionario = validarFuncionario.ValidacaoFuncionario();
MenuPrincipal.MenuInicial(identidadeFuncionario);
}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}



