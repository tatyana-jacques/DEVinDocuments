using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevInDocuments.Entities
{
    public class ValidarFuncionario
    {
        int identidadeInserida;
        bool usuarioIdentificado = false;
        public int ValidacaoFuncionario()
        {
            Console.WriteLine("Olá Funcionário(a).");
            while (usuarioIdentificado == false)
            {
                try
                {
                    Console.Write("Insira o número de sua identidade para começar:");

                    var verificarIdentidade = int.TryParse(Console.ReadLine(), out identidadeInserida);
                    var identidadeEncontrada = Listas.ListaFuncionarios().Where(p => p.Id == identidadeInserida).First();
                    Console.WriteLine(@$"Bem vindo(a) ao sistema de cadastro e consulta de documentos.
                    {identidadeEncontrada}");
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
