namespace DevInDocuments.Entities
{
    public class ValidarFuncionario
    {
        bool usuarioIdentificado = false;
        string identidadeInserida = string.Empty;
        public string ValidacaoFuncionario()
        {
            Console.WriteLine("Olá Funcionário(a).");
            while (usuarioIdentificado == false)
            {
                try
                {
                    Console.Write("Insira o número de sua identidade para começar:");

                    identidadeInserida = Console.ReadLine() ?? string.Empty;
                    var identidadeEncontrada = Listas.ListaFuncionarios().Where(p => p.Id == identidadeInserida).First();
                    Console.WriteLine($"Bem vindo(a) ao sistema de cadastro e consulta de documentos.{identidadeEncontrada}");
                    Console.WriteLine();
                    Console.WriteLine("==============================================");
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
