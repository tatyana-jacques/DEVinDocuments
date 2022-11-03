
namespace DevInDocuments.Entities.Static
{
    public static class CadastrarNotaFiscal
    {
        public static void CadastroNotaFiscal(string funcionario)
        {
            bool escolhaTipoImposto = false;
            bool verificarValorTotal = false;
            bool verificarValorImposto = false;
            decimal valorTotalInserido = 0;
            decimal valorImpostoInserido = 0;

            NotaFiscal nota = new NotaFiscal(
            nomeEstabelecimento: string.Empty,
            cnpj: string.Empty,
            identificacaoFuncionario: string.Empty,
            nomeProduto: string.Empty,
            tipoImposto: string.Empty,
            statusDocumento: string.Empty);
            nota.IdentificacaoFuncionario = funcionario;


            //Set nome
            while (nota.NomeEstabelecimento == string.Empty)
            {
                Console.Write("Insira o nome do estabelecimento: ");
                nota.NomeEstabelecimento = Console.ReadLine() ?? string.Empty;
            }

            //Set CNPJ
            while (nota.CNPJ == string.Empty)
            {
                Console.Write("Insira o CNPJ do estabelecimento: ");
                nota.CNPJ = Console.ReadLine() ?? string.Empty;
            }

            //Set status
            nota.StatusDocumento = CadastrarStatusDocumento.CadastroStatus().ToString();

            //Set nome do produto
            while (nota.NomeProduto ==string.Empty){
            Console.WriteLine("Insira o nome do produto: ");
            nota.NomeProduto = Console.ReadLine() ?? string.Empty;
            }

            //Set valor do produto
             Console.WriteLine("Insira o valor total do produto: ");
            while (verificarValorTotal == false)
            {
                verificarValorTotal = decimal.TryParse(Console.ReadLine(), out valorTotalInserido);
                if (verificarValorTotal == false)
                {
                    Console.WriteLine("Insira um valor de produto válido.");
                }

            }
            nota.ValorTotal = valorTotalInserido;

            //Set tipo de imposto
            while (escolhaTipoImposto == false)
            {
                    Console.WriteLine(@$"Escolha o número equivalente ao tipo de imposto: 
                                1- ICMS;
                                2- IPI;
                                3-IOF;
                                4-Outro;");
                    var escolhaImpostoUsuario = Console.ReadLine() ?? string.Empty;
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
                    else {
                        Console.WriteLine ("Escolha uma opção válida.");
                    }
                   
                    nota.TipoImposto = escolhaImpostoUsuario;
               
            }


            while (verificarValorImposto == false)
            {
                Console.WriteLine("Insira o valor do imposto: ");
                verificarValorImposto = decimal.TryParse(Console.ReadLine(), out valorImpostoInserido);
                if (verificarValorImposto == false)
                {
                    Console.WriteLine("Insira um valor de produto válido.");
                }
            }
            nota.ValorTotalImposto = valorImpostoInserido;

            nota.CadastrarDocumento(nota);
            MenuPrincipal.MenuInicial(funcionario);

        }

    }


}