namespace DevInDocuments.Entities.Validacoes
{
    public static class ValidarFuncionario
    {

        public static string ValidacaoFuncionario()
        {
            string identidadeInserida = string.Empty;
            Console.WriteLine("Olá Funcionário(a).");
                try
                {
                    Console.Write("Insira o número de sua identidade para começar:");
                    identidadeInserida = Console.ReadLine() ?? string.Empty;
                    var identidadeEncontrada = Listas.Funcionarios.Where(p => p.Id == identidadeInserida).First();
                    Console.WriteLine("Bem vindo(a) ao sistema de cadastro e consulta de documentos."+
                    $"\n{identidadeEncontrada}");
                }
                catch (InvalidOperationException)
                {

                    Console.WriteLine("Identificação de  usuário inválida!");
                    ValidacaoFuncionario();
                }
            
            return identidadeInserida;
        }
    }
}
