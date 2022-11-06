namespace DevInDocuments.Entities
{
    public static class ValidarFuncionario
    {

        public static string ValidacaoFuncionario()
        {
            bool usuarioIdentificado = false;
            string identidadeInserida = string.Empty;
            Console.WriteLine("Olá Funcionário(a).");
            while (usuarioIdentificado == false)
            {
                try
                {
                    Console.Write("Insira o número de sua identidade para começar:");

                    identidadeInserida = Console.ReadLine() ?? string.Empty;
                    var identidadeEncontrada = Listas.Funcionarios.Where(p => p.Id == identidadeInserida).First();
                    Console.Clear();
                    Console.WriteLine($"Bem vindo(a) ao sistema de cadastro e consulta de documentos.{identidadeEncontrada}");
                    Console.WriteLine();
                    usuarioIdentificado = true;
                }
                catch (InvalidOperationException)
                {

                    Console.WriteLine("Identificação de  usuário inválida!");
                }
            }
            return identidadeInserida;
        }
    }
}
