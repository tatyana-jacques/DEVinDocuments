
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
                    4-Voltar ao Menu Inicial."
                       );

                var escolhaMenuListar = Console.ReadLine();


                if (escolhaMenuListar == "1")
                {


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
                    entrarMenuListarDocumentos = false;

                }
                if (escolhaMenuListar == "4")
                {
                    entrarMenuListarDocumentos = true;
                    MenuPrincipal.MenuInicial(funcionario);
                }

            }



        }
    }
}