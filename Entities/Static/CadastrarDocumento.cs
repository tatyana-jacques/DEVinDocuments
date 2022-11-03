using DevInDocuments.Entities.Exceptions;
namespace DevInDocuments.Entities.Static
{
    public static class CadastrarDocumento
    {
        public static void CadastroDocumento(string funcionario)
        {
            bool escolhaTipoDocumento = false;
            bool escolhaTipoImposto = false;
            bool verificarValorTotal = false;
            bool verificarValorImposto = false;
            bool escolhaStatusDocumento = false;
            string nomeEstabelecientoInserido = string.Empty;

            NotaFiscal nota = new NotaFiscal(
                nomeEstabelecimento: string.Empty,
                cnpj: string.Empty,
                identificacaoFuncionario: string.Empty,
                nomeProduto: string.Empty,
                tipoImposto: string.Empty,
                statusDocumento: string.Empty);
            nota.IdentificacaoFuncionario = funcionario;

            //Set nome do estabelecimento
            while (nota.NomeEstabelecimento == string.Empty)
            {
                Console.Write("Insira o nome do estabelecimento: ");
                nomeEstabelecientoInserido = Console.ReadLine() ?? string.Empty;
            }

            //Set CNPJ
            while (nota.CNPJ == string.Empty)
            {
                Console.Write("Insira o CNPJ do estabelecimento: ");
                var cnpjEstabelecientoInserido = Console.ReadLine() ?? string.Empty;
                nota.CNPJ = cnpjEstabelecientoInserido;
            }

            //Set status
             while (escolhaStatusDocumento == false)
                {
                    try
                    {
                        Console.WriteLine(@$"Selecione o número equivalente ao status do documento: 
                        1-Ativo;
                        2-Em transição;
                        3-Suspenso.");
                        var statusDocumentoInserido = Console.ReadLine() ?? string.Empty;
                        if (statusDocumentoInserido == "1")
                        {
                            statusDocumentoInserido = "Ativo";
                            escolhaStatusDocumento = true;
                        }
                        else if (statusDocumentoInserido == "2")
                        {
                            statusDocumentoInserido = "Em transição.";
                            escolhaStatusDocumento = true;
                        }
                        else if (statusDocumentoInserido == "3")
                        {
                            statusDocumentoInserido = "Suspenso";
                            escolhaStatusDocumento = true;
                        }
                        else
                        {
                            throw new OpcaoInexistenteException();
                        }
                        nota.StatusDocumento = statusDocumentoInserido;
                    }
                    catch (OpcaoInexistenteException) { }

                }

            //Set tipo de documento

            while (escolhaTipoDocumento == false)
            {
                try
                {
                    Console.WriteLine(@$"Selecione o número correspondente ao tipo de documento que deseja criar: 
                        1- Nota Fiscal;
                        2- Licença de Funcionamento.
                        3- Contrato.");
                    var escolhaUsuarioDocumento = Console.ReadLine();
                    
                    //O documento é nota fiscal
                    if (escolhaUsuarioDocumento == "1")
                    {
                        Console.WriteLine("Insira o nome do produto: ");
                        var escolhaNomeProduto = Console.ReadLine();
                        Console.WriteLine("Insira o valor total do produto: ");
                        decimal valorTotalInserido;
                        while (verificarValorTotal == false)
                        {
                            verificarValorTotal = decimal.TryParse(Console.ReadLine(), out valorTotalInserido);
                            if (verificarValorTotal == false)
                            {
                                Console.WriteLine("Insira um valor de produto válido.");
                            }
                        }
                        
                        //Set tipo de imposto
                        while (escolhaTipoImposto == false)
                        {
                            try
                            {
                                Console.WriteLine(@$"Escolha o número equivalente ao tipo de imposto: 
                                1- ICMS;
                                2- IPI;
                                3-IOF;
                                4-Outro;");
                                var escolhaImpostoUsuario = Console.ReadLine();
                                if (escolhaImpostoUsuario == "1")
                                {
                                    escolhaImpostoUsuario = "ICMS";
                                    escolhaTipoImposto = true;
                                }
                                else if (escolhaImpostoUsuario == "2")
                                {
                                    escolhaImpostoUsuario = "IPI";
                                    escolhaTipoImposto = true;

                                }
                                else if (escolhaImpostoUsuario == "3")
                                {
                                    escolhaImpostoUsuario = "IOF";
                                    escolhaTipoImposto = true;

                                }
                                else if (escolhaImpostoUsuario == "4")
                                {
                                    escolhaImpostoUsuario = "Outro";
                                    escolhaTipoImposto = true;

                                }
                                else
                                {
                                    throw new OpcaoInexistenteException();
                                }
                                 nota.TipoImposto = escolhaImpostoUsuario;
                            }

                            catch (OpcaoInexistenteException) { }
                        }
                       


                        decimal valorImpostoInserido;
                        while (verificarValorImposto == false)
                        {
                            verificarValorImposto = decimal.TryParse(Console.ReadLine(), out valorImpostoInserido);
                            if (verificarValorImposto == false)
                            {
                                Console.WriteLine("Insira um valor de produto válido.");
                            }
                        }



                    }

                }
                catch (OpcaoInexistenteException) { }



            }

                nota.NomeEstabelecimento = nomeEstabelecientoInserido;
                nota.CadastrarDocumento(nota);
                escolhaTipoDocumento = true;
                MenuPrincipal.MenuInicial(funcionario);







            }

        }
    }