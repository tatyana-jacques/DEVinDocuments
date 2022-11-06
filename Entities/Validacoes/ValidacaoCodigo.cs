using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevInDocuments.Entities.Validacoes
{
    public static class ValidacaoCodigo
    {
        public static string Codigo (){
            bool inserirCodigo = false;
            string documentoEscolhido = string.Empty;
            while (inserirCodigo == false)
            {
                Console.Write("Digite os quatro primeiros caracteres do código do documento que deseja alterar: ");
                documentoEscolhido = Console.ReadLine() ?? string.Empty;
                if (documentoEscolhido.Length != 4)
                {
                    Console.WriteLine("Você deve inserir quatro caracteres!");
                }
                else {
                    inserirCodigo = true;
                }
            }
            return documentoEscolhido;

        }
        
    }
}