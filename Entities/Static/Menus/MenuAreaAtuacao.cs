using DevInDocuments.Entities.Enumerators;
namespace DevInDocuments.Entities.Static
{
    public static class MenuAreaAtuacao
    {
        public static AreaAtuacao EscolhaAreaAtuacao()
        {
            AreaAtuacao areaAtuacao = AreaAtuacao.Outro;

            Console.WriteLine(
                "==================================================================================" +
                "\n 1- Industrial;" + 
                "\n 2- Agropecuário;" +
                "\n 3-Metalúrgico;" + 
                "\n 4-Tecnologia; " + 
                "\n 5-Outro;");

            Console.Write("Digite o número de sua opção: ");

            var escolhaAreaUsuario = Console.ReadLine() ?? string.Empty;

            switch (escolhaAreaUsuario)
            {
                case "1":
                    areaAtuacao = AreaAtuacao.Industrial;
                    break;
                case "2":
                    areaAtuacao = AreaAtuacao.Agropecuario;
                    break;
                case "3":
                    areaAtuacao = AreaAtuacao.Metalurgico;
                    break;
                case "4":
                    areaAtuacao = AreaAtuacao.Tecnologia;
                    break;
                case "5":
                    areaAtuacao = AreaAtuacao.Outro;
                    break;
                default:
                    Console.WriteLine("Escolha uma opção válida.");
                    MenuAreaAtuacao.EscolhaAreaAtuacao();
                    break;

            }
            return areaAtuacao;
        }
    }
}