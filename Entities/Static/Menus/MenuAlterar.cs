
using DevInDocuments.Entities.Static;
using DevInDocuments.Entities.Exceptions;
namespace DevInDocuments.Entities.Static.Menus
{
    public static class MenuAlterar
    {
        public static void AlterarDocumento(string funcionario)
        {
            bool entrarMenuAlterarDocumentos = false;

            while (entrarMenuAlterarDocumentos == false)
            {
                try
                {
                    Console.WriteLine(
                    @$"=========================================================
                    Insira o número da operação que deseja realizar:
                    1- Alterar Nota Fiscal;
                    2- Alterar Licença de Funcionamento;
                    3- Alterar Contrato;
                    4- Voltar ao menu inicial."
                           );

                    var escolhaMenuAlterar = Console.ReadLine();

                    switch (escolhaMenuAlterar)
                    {
                        case "1":
                            entrarMenuAlterarDocumentos = true;
                            NotaFiscal nota = new NotaFiscal(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
                            Console.Clear();
                            Console.WriteLine("Lista de Notas Fiscais: ");
                            nota.ListarDocumento();
                            nota.AlterarDocumento(funcionario);
                            MenuPrincipal.MenuInicial(funcionario);
                            break;
                        case "2":
                            entrarMenuAlterarDocumentos = true;
                            LicencaFuncionamento licenca = new LicencaFuncionamento(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
                            Console.Clear();
                            Console.WriteLine("Lista de Licenças de Funcionamento: ");
                            licenca.ListarDocumento();
                            licenca.AlterarDocumento(funcionario);
                            MenuPrincipal.MenuInicial(funcionario);
                            break;
                        case "3":
                            entrarMenuAlterarDocumentos = true;
                            Contrato contrato = new Contrato(string.Empty, string.Empty, string.Empty, string.Empty);
                            Console.WriteLine("Lista de Notas Fiscais: ");
                            contrato.ListarDocumento();
                            contrato.AlterarDocumento(funcionario);
                            MenuPrincipal.MenuInicial(funcionario);
                            break;
                        case "4":
                            entrarMenuAlterarDocumentos = true;
                            MenuPrincipal.MenuInicial(funcionario);
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