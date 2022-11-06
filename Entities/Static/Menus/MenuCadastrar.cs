using DevInDocuments.Entities.Exceptions;
namespace DevInDocuments.Entities.Static.Menus
{
    public static class MenuCadastrar
    {
        public static void MenuCadastroDocumento(string funcionario)
        {
            Console.WriteLine(
                "==================================================================================" +
                "\nSelecione o tipo de documento que deseja criar: " + 
                "\n1-Nota Fiscal;" + 
                "\n2-Licença de Funcionamento;" +
                "\n3-Contrato;" + 
                "\n4-Voltar ou menu inicial.");
            Console.Write("Digite o número de sua opção: ");
            var escolhaUsuarioDocumento = Console.ReadLine();

            switch (escolhaUsuarioDocumento)
            {
                case "1":
                    NotaFiscal nota = new NotaFiscal(string.Empty, string.Empty, string.Empty, string.Empty);
                    nota.CadastrarDocumento(funcionario);
                    MenuPrincipal.MenuInicial(funcionario);
                    break;
                case "2":
                    LicencaFuncionamento licenca = new LicencaFuncionamento(string.Empty, string.Empty, string.Empty, string.Empty);
                    licenca.CadastrarDocumento(funcionario);
                    MenuPrincipal.MenuInicial(funcionario);
                    break;
                case "3":
                    Contrato contrato = new Contrato(string.Empty, string.Empty, string.Empty, string.Empty);
                    contrato.CadastrarDocumento(funcionario);
                    MenuPrincipal.MenuInicial(funcionario);
                    break;
                case "4":
                    MenuPrincipal.MenuInicial(funcionario);
                    break;
                default:
                    throw new OpcaoInexistenteException("Opção de cadastro inexistente.");
            }

        }

    }
}
