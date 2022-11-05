
namespace DevInDocuments.Entities.Static
{
    public static class MenuAreaAtuacao
    {
        public static string AreaAtuacao()
        {
            var AreaAtuacao = string.Empty;
            while (AreaAtuacao == string.Empty)
            {

                Console.WriteLine(@$"Escolha a área de atuação do negócio: 
                                1- Industrial;
                                2- Agropecuário;
                                3-Metalúrgico;
                                4-Tecnologia;
                                5-Outro;");

                Console.Write("Digite o número de sua opção: ");

                var escolhaAreaUsuario = Console.ReadLine() ?? string.Empty;

                switch (escolhaAreaUsuario)
                {
                    case "1":
                        AreaAtuacao = "Industrial";
                        break;
                    case "2":
                        AreaAtuacao = "Agropecuário";
                        break;
                    case "3":
                        AreaAtuacao = "Metalúrgico";
                        break;
                    case "4":
                        AreaAtuacao = "Tecnologia";
                        break;
                    case "5":
                        AreaAtuacao = "Outro";
                        break;
                    default:
                        Console.WriteLine("Escolha uma opção válida.");
                        break;

                }

            }
            return AreaAtuacao;
        }
    }
}