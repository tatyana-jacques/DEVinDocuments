
using DevInDocuments.Entities.Exceptions;
namespace DevInDocuments.Entities.Static.Menus
{
    public static class MenuAlterar
    {
        public static void AlterarDocumento(string funcionario)
        {
            Console.WriteLine(
            "==================================================================================" +
            "\nQual tipo de documento deseja alterar?" +
            "\n1-Alterar Nota Fiscal;" +
            "\n2-Alterar Licença de Funcionamento;" +
            "\n3-Alterar Contrato;" +
            "\n4-Voltar ao menu inicial.");

            Console.Write("Digite o número de sua opção: ");
            var escolhaMenuAlterar = Console.ReadLine();

            switch (escolhaMenuAlterar)
            {
                case "1":
                    Console.WriteLine("Seguem as notas fiscais disponíveis: ");
                    NotaFiscal nota = new NotaFiscal(string.Empty, string.Empty, string.Empty, string.Empty);
                    nota.ListarDocumento();
                    nota.AlterarDocumento(funcionario);
                    break;
                case "2":
                    Console.WriteLine ("Seguem as licenças de funcionamento disponíveis: ");
                    LicencaFuncionamento licenca = new LicencaFuncionamento(string.Empty, string.Empty, string.Empty, string.Empty);
                    licenca.ListarDocumento();
                    licenca.AlterarDocumento(funcionario);
                    break;
                case "3":
                    Console.WriteLine ("Seguem os contratos disponíveis: ");
                    Contrato contrato = new Contrato(string.Empty, string.Empty, string.Empty, string.Empty);
                    contrato.ListarDocumento();
                    contrato.AlterarDocumento(funcionario);
                    break;
                case "4":
                    break;
                default:
                    throw new OpcaoInexistenteException("Opção inexistente no menu de alteração de documento.");
            }

            MenuPrincipal.MenuInicial(funcionario);
        }
    }
}