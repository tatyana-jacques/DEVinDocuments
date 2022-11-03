
namespace DevInDocuments.Entities.Static
{
    public static class MenuListarDocumentos
    {
        public static void EscolherListaDocumentos(string funcionario)
        {

            bool entrarMenuListarDocumentos = false;
            while (entrarMenuListarDocumentos == false)
            {
                Console.WriteLine(@$"Insira o número da operação que deseja realizar:
                    1- Listar todos os documentos;
                    2- Listar Notas Fiscais;
                    3-Listar Licenças de Funcionamento;
                    4-Listar Contratos;
                    5-Voltar ao Menu Inicial."
                       );

                var escolhaMenuListar = Console.ReadLine();


                if (escolhaMenuListar == "1")
                {
                    Listas.ListarTodosDocumentos();
                     //entrarMenuListarDocumentos = false;


                }

                if (escolhaMenuListar == "2")
                {
                    NotaFiscal nota = new NotaFiscal(string.Empty,
                        cnpj: string.Empty,
                        identificacaoFuncionario: string.Empty,
                        nomeProduto: string.Empty,
                        tipoImposto: string.Empty,
                        statusDocumento: string.Empty);
                    nota.ListarDocumento();
                    //entrarMenuListarDocumentos = false;

                }
                if (escolhaMenuListar == "3")
                {
                    LicencaFuncionamento licenca = new LicencaFuncionamento(string.Empty,
                        cnpj: string.Empty,
                        identificacaoFuncionario: string.Empty,
                        endereco: string.Empty,
                        areaAtuacao: string.Empty,
                        statusDocumento: string.Empty);
                    licenca.ListarDocumento();
                    //entrarMenuListarDocumentos = false;

                }
                if (escolhaMenuListar == "4")
                {
                    Contrato contrato = new Contrato(string.Empty,
                        cnpj: string.Empty,
                        identificacaoFuncionario: string.Empty,
                        finalidade: string.Empty,
                        statusDocumento: string.Empty);
                    contrato.ListarDocumento();
                    //entrarMenuListarDocumentos = false;

                }
                if (escolhaMenuListar == "5")
                {
                    entrarMenuListarDocumentos = true;
                    MenuPrincipal.MenuInicial(funcionario);
                }

            }

        }
    }
}