using DevInDocuments.Entities.Exceptions;
namespace DevInDocuments.Entities.Static.Menus
{
    public static class MenuCadastrar
    {
        public static void MenuCadastroDocumento(string funcionario)
        {
            bool escolhaTipoDocumento = false;

            while (escolhaTipoDocumento == false)
            {
                try
                {
                    Console.WriteLine(
                        @$"==================================================================================
                        Selecione o tipo de documento que deseja criar: 
                        1- Nota Fiscal;
                        2- Licença de Funcionamento;
                        3- Contrato;
                        4-Vontar ou menu inicia.");
                        Console.Write ("Digite o número de sua opção: ");
                    var escolhaUsuarioDocumento = Console.ReadLine();

                    switch (escolhaUsuarioDocumento)
                    {
                        case "1":
                            escolhaTipoDocumento = true;
                            NotaFiscal nota = new NotaFiscal(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
                            nota.CadastrarDocumento(funcionario);
                            MenuPrincipal.MenuInicial(funcionario);
                            break;
                        case "2":
                            escolhaTipoDocumento = true;
                            LicencaFuncionamento licenca = new LicencaFuncionamento(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
                            licenca.CadastrarDocumento(funcionario);
                            MenuPrincipal.MenuInicial(funcionario);
                            break;
                        case "3":
                            escolhaTipoDocumento = true;
                            Contrato contrato = new Contrato (string.Empty, string.Empty, string.Empty, string.Empty);
                            contrato.CadastrarDocumento(funcionario);
                            MenuPrincipal.MenuInicial(funcionario);
                            break;
                        case "4":
                            escolhaTipoDocumento = true;
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