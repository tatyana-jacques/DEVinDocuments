
using DevInDocuments.Entities.Static;
namespace DevInDocuments.Entities.Exceptions
{
    public static class MenuAlterar
    {
        public static void AlterarDocumento(string funcionario)
        {
            bool entrarMenuAlterarDocumentos = false;

            while (entrarMenuAlterarDocumentos == false)

            {
                Console.WriteLine(@$"Insira o número da operação que deseja realizar:
                    1- Alterar Nota Fiscal;
                    2- Alterar Licença de Funcionamento;
                    3- Alterar Contrato;
                    4- Voltar ao menu inicial."
                       );

                var escolhaMenuAlterar = Console.ReadLine();


                if (escolhaMenuAlterar == "1")
                {
                    entrarMenuAlterarDocumentos = true;
                    NotaFiscal nota = new NotaFiscal(
                        nomeEstabelecimento: string.Empty,
                        cnpj: string.Empty,
                        identificacaoFuncionario: string.Empty,
                        nomeProduto: string.Empty,
                        tipoImposto: string.Empty,
                        statusDocumento: string.Empty);
                    Console.WriteLine("Lista de Notas Fiscais: ");
                    nota.ListarDocumento();
                    nota.AlterarDocumento(funcionario);
                    MenuPrincipal.MenuInicial(funcionario);


                }

                if (escolhaMenuAlterar == "2")
                {

                }
                if (escolhaMenuAlterar == "3")
                {

                }

                if (escolhaMenuAlterar == "4")
                {
                    entrarMenuAlterarDocumentos = true;
                    MenuPrincipal.MenuInicial(funcionario);
                }

            }

        }
    }
}