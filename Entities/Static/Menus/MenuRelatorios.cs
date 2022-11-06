using DevInDocuments.Entities.Exceptions;
using DevInDocuments.Entities.Enumerators;

namespace DevInDocuments.Entities.Static.Menus
{
    public static class MenuRelatorios
    {
        public static void ApresentarRelatorio(string funcionario)
        {

            Console.WriteLine(
            "==================================================================================" +
            "\nQual o tipo de relatório que deseja gerar:" +
            "\n1-Listar documentos ativos;" +
            "\n2-Listar documentos em tramitação;" +
            "\n3-Listar documentos suspensos;" +
            "\n4-Apresentar total de documentos;" +
            "\n5-Voltar ao Menu inicial.");
            Console.Write("Insira o número de sua opção: ");
            var escolhaMenuRelatorio = Console.ReadLine();

            switch (escolhaMenuRelatorio)
            {
                case "1":
                    Console.WriteLine("Segue a lista de documentos ativos: ");
                    foreach (DevInDocuments item in Listas.Lista)
                        if (item.StatusDocumento == Status.Ativo)
                        {
                            Console.WriteLine(item);
                        }
                    break;
                case "2":
                    Console.WriteLine("Segue a lista de documentos em tramitação: ");
                    foreach (DevInDocuments item in Listas.Lista)
                        if (item.StatusDocumento == Status.Tramitando)
                        {
                            Console.WriteLine(item);
                        }

                    break;
                case "3":
                    Console.WriteLine("Segue a lista de documentos suspensos: ");
                    foreach (DevInDocuments item in Listas.Lista)
                        if (item.StatusDocumento == Status.Suspenso)
                        {
                            Console.WriteLine(item);
                        }
                    break;
                case "4":
                    Console.WriteLine($"Total de documentos: {Listas.Lista.Count}");
                    break;
                case "5":
                    break;
                default:
                    throw new OpcaoInexistenteException("Opção de listagem de documentos inexistente.");
            }
            MenuPrincipal.MenuInicial(funcionario);
        }

    }
}