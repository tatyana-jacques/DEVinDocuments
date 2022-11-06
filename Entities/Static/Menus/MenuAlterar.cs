
using DevInDocuments.Entities.Exceptions;
namespace DevInDocuments.Entities.Static.Menus
{
    public static class MenuAlterar
    {
        public static void AlterarDocumento(string funcionario)
        {
            Console.WriteLine(
            "==================================================================================" +
            "\n Insira o número da operação que deseja realizar:" +
            "\n 1- Alterar Nota Fiscal;" +
            " \n 2- Alterar Licença de Funcionamento;" +
            "\n 3 - Alterar Contrato;" +
            " \n 4 - Voltar ao menu inicial.");

            var escolhaMenuAlterar = Console.ReadLine();

            switch (escolhaMenuAlterar)
            {
                case "1":
                    NotaFiscal nota = new NotaFiscal(string.Empty, string.Empty, string.Empty, string.Empty);
                    nota.ListarDocumento();
                    nota.AlterarDocumento(funcionario);
                    break;
                case "2":
                    LicencaFuncionamento licenca = new LicencaFuncionamento(string.Empty, string.Empty, string.Empty, string.Empty);
                    licenca.ListarDocumento();
                    licenca.AlterarDocumento(funcionario);
                    break;
                case "3":
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