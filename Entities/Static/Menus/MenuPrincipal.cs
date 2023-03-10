using DevInDocuments.Entities.Static;
using DevInDocuments.Entities.Exceptions;


namespace DevInDocuments.Entities.Static.Menus
{
    public static class MenuPrincipal
    {
        public static void MenuInicial(string funcionario)
        {

            try
            {

                Console.WriteLine();
                Console.WriteLine(
                "==================================================================================" +
                "\nSelecione a operação que deseja realizar:" +
                "\n1-Cadastrar documento;" +
                "\n2-Listar documentos;" +
                "\n3-Alterar documento;" +
                "\n4-Alterar status do documento;" +
                "\n5-Relatórios;" +
                "\n6-Sair do sistema.");
                Console.Write("Digite o número de sua opção: ");
                var escolhaMenuInicial = Console.ReadLine();

                switch (escolhaMenuInicial)
                {
                    case "1":
                        MenuCadastrar.MenuCadastroDocumento(funcionario);
                        break;
                    case "2":
                        MenuListarDocumentos.EscolherListaDocumentos(funcionario);
                        break;
                    case "3":
                        MenuAlterar.AlterarDocumento(funcionario);
                        break;
                    case "4":
                        Contrato documento = new Contrato(string.Empty, string.Empty, string.Empty, string.Empty);
                        documento.AlterarStatus();
                        MenuPrincipal.MenuInicial(funcionario);
                        break;
                    case "5":
                        MenuRelatorios.ApresentarRelatorio(funcionario);
                        break;
                    case "6":
                        break;
                    default:
                        throw new OpcaoInexistenteException("Opção de Menu inexistente.");
                }

            }
            catch (OpcaoInexistenteException)
            {
                MenuPrincipal.MenuInicial(funcionario);
            }


        }
    }
}