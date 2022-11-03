using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevInDocuments.Entities.Static
{
    public static class MenuAreaAtuacao
    {
        public static string AreaAtuacao()
        {
             string AreaAtuacao = string.Empty;
            
            while (AreaAtuacao == string.Empty)
            {

                Console.WriteLine(@$"Escolha o número equivalente à área de atuação do negócio: 
                                1- Industrial;
                                2- Agropecuário;
                                3-Metalúrgico;
                                4-Tecnologia;
                                5-Outro;");
                var escolhaAreaUsuario = Console.ReadLine() ?? string.Empty;
                
                if (escolhaAreaUsuario == "1")
                {
                     AreaAtuacao = "Industrial"; 
                }
                else if (escolhaAreaUsuario == "2")
                { 
                    AreaAtuacao = "Agropecuário";
                }
                else if (escolhaAreaUsuario == "3")
                {
                    AreaAtuacao = "Metalúrgico";
                }
                else if (escolhaAreaUsuario == "4")
                {
                    AreaAtuacao = "Tecnologia";
                }
                else if (escolhaAreaUsuario == "5")
                {
                    AreaAtuacao = "Outro";
                }
                else
                {
                    Console.WriteLine("Escolha uma opção válida.");
                   
                }            

            }
            return AreaAtuacao;
        }
    }
}