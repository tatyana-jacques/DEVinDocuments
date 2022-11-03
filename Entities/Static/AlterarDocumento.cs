using DevInDocuments.Entities.Static;
namespace DevInDocuments.Entities.Exceptions
{
    public static class AlterarDocumento
    {
        public static void EditarDocumento(string funcionario)
        {
            bool entrarMenuAlterarDocumentos = false;
            bool inserirCodigo = false;
            string documentoEscolhido = string.Empty;
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

                    nota.ListarDocumento();

                    while (inserirCodigo == false)
                    {

                        Console.WriteLine("Digite os quatro primeiros dígitos do código do documento que deseja alterar: ");
                        documentoEscolhido = Console.ReadLine() ?? string.Empty;
                        if (documentoEscolhido.Length != 4)
                        {
                            Console.WriteLine("Você deve inserir quatro caracteres!");
                        }
                        else
                        {
                            foreach (NotaFiscal x in Listas.ListaNotasFiscais)
                            {
                                if (x.codigoDocumento.StartsWith(documentoEscolhido))
                                {
                                    Console.WriteLine($"Nota Fiscal escolhida: {x}");
                                    nota.AlterarDocumento(x);
                                    inserirCodigo = true;
                                }

                            }

                        }

                    }
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