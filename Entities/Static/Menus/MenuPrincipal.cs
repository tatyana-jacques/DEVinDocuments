using DevInDocuments.Entities.Static;
using DevInDocuments.Entities.Exceptions;

namespace DevInDocuments.Entities
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
                    Console.WriteLine(@$"Selecione a operação que deseja realizar:
                    1- Cadastrar documento;
                    2-Listar documento;
                    3-Alterar documento;
                    4-Alterar status do documento;
                    5-Relatórios;
                    6-Sair do sistema.");
                    Console.Write("Digite sua opção: ");
                    var escolhaMenuInicial = Console.ReadLine();

                    switch (escolhaMenuInicial)
                    {
                        case "1":
                            MenuCadastrar.MenuCadastroDocumento(funcionarioOperando);
                            entrarMenuInicial = true;
                            break;
                        case "2":
                            MenuListarDocumentos.EscolherListaDocumentos(funcionarioOperando);
                            entrarMenuInicial = true;
                            break;
                        case "3":
                            MenuAlterar.AlterarDocumento(funcionario);
                            entrarMenuInicial = true;
                            break;
                        case "4":
                            Contrato documento = new Contrato(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
                            documento.AlterarStatus();
                            break;
                        case "5":
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