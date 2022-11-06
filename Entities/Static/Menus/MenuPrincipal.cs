using DevInDocuments.Entities.Static;
using DevInDocuments.Entities.Exceptions;


namespace DevInDocuments.Entities.Static.Menus
{
    public static class MenuPrincipal
    {
        public static void MenuInicial(string funcionario)
        {
            bool entrarMenuInicial = false;
            string funcionarioOperando = funcionario;

            while (entrarMenuInicial == false)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine(
                    @$"==================================================================================
                    Selecione a operação que deseja realizar:
                    1- Cadastrar documento;
                    2-Listar documentos;
                    3-Alterar documento;
                    4-Alterar status do documento;
                    5-Relatórios;
                    6-Sair do sistema.");
                    Console.Write("Digite sua opção: ");
                    var escolhaMenuInicial = Console.ReadLine();

                    switch (escolhaMenuInicial)
                    {
                        case "1":
                            entrarMenuInicial = true;
                            MenuCadastrar.MenuCadastroDocumento(funcionarioOperando);
                            break;
                        case "2":
                            entrarMenuInicial = true;
                            MenuListarDocumentos.EscolherListaDocumentos(funcionarioOperando);
                            break;
                        case "3":
                            entrarMenuInicial = true;
                            MenuAlterar.AlterarDocumento(funcionario);
                            break;
                        case "4":
                            Contrato documento = new Contrato(string.Empty, string.Empty, string.Empty, string.Empty);
                            documento.AlterarStatus();
                            break;
                        case "5":
                            MenuRelatorios.ApresentarRelatorio(funcionario);
                            entrarMenuInicial = true;
                            break;
                        case "6":
                            entrarMenuInicial = true;
                            break;
                        default:
                            throw new OpcaoInexistenteException();
                    }

                }
                catch (OpcaoInexistenteException) { }

            }
        }
    }
}