using DevInDocuments.Entities.Exceptions;
namespace DevInDocuments.Entities.Static.Menus
{
    public static class MenuListarDocumentos
    {
        public static void EscolherListaDocumentos(string funcionario)
        {

            {
                Console.WriteLine(
                    "==================================================================================" + 
                    "\nQual tipo de documento deseja listar?"+
                    "\n1-Listar todos os documentos;"+
                    "\n2-Listar Notas Fiscais;" +
                    "\n3-Listar Licenças de Funcionamento;" +
                    "\n4-Listar Contratos;" + 
                    "\n5-Voltar ao Menu Inicial.");
                Console.Write("Digite o número de sua opção: ");

                var escolhaMenuListar = Console.ReadLine();
                switch (escolhaMenuListar)
                {
                    case "1":
                        Console.WriteLine("Seguem todos os documentos do sistema: ");
                        Listas.ListarTodosDocumentos();

                        break;
                    case "2":
                        Console.WriteLine("Seguem todas as Notas Fiscais do sistema: ");
                        NotaFiscal nota = new NotaFiscal(string.Empty, string.Empty, string.Empty, string.Empty);
                        nota.ListarDocumento();
                        break;
                    case "3":
                        Console.WriteLine("Seguem todas as Licenças de Funcionamento do sistema: ");
                        LicencaFuncionamento licenca = new LicencaFuncionamento(string.Empty, string.Empty, string.Empty, string.Empty);
                        licenca.ListarDocumento();
                        break;
                    case "4":
                        Console.WriteLine("Seguem todos os Contratos do sistema: ");
                        Contrato contrato = new Contrato(string.Empty, string.Empty, string.Empty, string.Empty);
                        contrato.ListarDocumento();
                        break;
                    case "5":
                        MenuPrincipal.MenuInicial(funcionario);
                        break;
                    default:
                       throw new OpcaoInexistenteException("Opção inexistente em menu de listagem de documento!");
                }
                MenuPrincipal.MenuInicial(funcionario);
            }
        }
    }
}
