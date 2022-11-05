
namespace DevInDocuments.Entities.Static
{
    public static class MenuListarDocumentos
    {
        public static void EscolherListaDocumentos(string funcionario)
        {

            bool entrarMenuListarDocumentos = false;
            while (entrarMenuListarDocumentos == false)
            {
                Console.Clear();
                Console.WriteLine(@$" ===================================
                    Insira a operação que deseja realizar:
                    1- Listar todos os documentos;
                    2- Listar Notas Fiscais;
                    3-Listar Licenças de Funcionamento;
                    4-Listar Contratos;
                    5-Voltar ao Menu Inicial.");
                    Console.Write("Digite o número de sua opção: ");

                var escolhaMenuListar = Console.ReadLine();
                switch (escolhaMenuListar)
                {
                    case "1":
                        entrarMenuListarDocumentos = true;
                        Console.WriteLine("Seguem todos os documentos do sistema: ");
                        Listas.ListarTodosDocumentos();
                        MenuPrincipal.MenuInicial(funcionario);
                        break;
                    case "2":
                        Console.WriteLine("Seguem todas as Notas Fiscais do sistema: ");
                        NotaFiscal nota = new NotaFiscal(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
                        nota.ListarDocumento();
                        entrarMenuListarDocumentos = true;
                        MenuPrincipal.MenuInicial(funcionario);
                        break;
                    case "3":
                        Console.WriteLine("Seguem todas as Licenças de Funcionamento do sistema: ");
                        LicencaFuncionamento licenca = new LicencaFuncionamento(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
                        licenca.ListarDocumento();
                        entrarMenuListarDocumentos = true;
                        MenuPrincipal.MenuInicial(funcionario);
                        break;
                    case "4":
                        Console.WriteLine("Seguem todos os Contratos do sistema: ");
                        Contrato contrato = new Contrato(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
                        contrato.ListarDocumento();
                        entrarMenuListarDocumentos = true;
                        MenuPrincipal.MenuInicial(funcionario);
                        break;
                    case "5":
                        entrarMenuListarDocumentos = true;
                        MenuPrincipal.MenuInicial(funcionario);
                        break;
                    default:
                        Console.WriteLine("Escolha uma opção válida.");
                        break;
                }

            }

        }

    }
}
