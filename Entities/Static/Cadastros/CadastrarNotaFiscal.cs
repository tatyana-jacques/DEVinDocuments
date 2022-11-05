
namespace DevInDocuments.Entities.Static
{
    public class CadastrarNotaFiscal
    {
        public static NotaFiscal CadastroNotaFiscal(string funcionario, NotaFiscal nota)
        {
            bool escolhaTipoImposto = false;
            bool verificarValorTotal = false;
            bool verificarValorImposto = false;
            decimal valorTotalInserido = 0;
            decimal valorImpostoInserido = 0;

            while (nota.NomeEstabelecimento == string.Empty)
            {
                Console.Write("Insira o nome do estabelecimento: ");
                nota.NomeEstabelecimento = Console.ReadLine() ?? string.Empty;
            }

            while (nota.CNPJ == string.Empty)
            {
                Console.Write("Insira o CNPJ do estabelecimento: ");
                nota.CNPJ = Console.ReadLine() ?? string.Empty;
            }

            nota.StatusDocumento = CadastrarStatusDocumento.CadastroStatus().ToString();

            while (nota.NomeProduto == string.Empty)
            {
                Console.Write("Insira o nome do produto: ");
                nota.NomeProduto = Console.ReadLine() ?? string.Empty;
            }

            Console.Write("Insira o valor total do produto: ");
            while (verificarValorTotal == false)
            {
                verificarValorTotal = decimal.TryParse(Console.ReadLine(), out valorTotalInserido);
                if (verificarValorTotal == false)
                {
                    Console.WriteLine("Insira um valor de produto válido.");
                }

            }
            nota.ValorTotal = valorTotalInserido;

            while (escolhaTipoImposto == false)
            {
                Console.WriteLine(@$"Escolha o tipo de imposto: 
                                1- ICMS;
                                2- IPI;
                                3-IOF;
                                4-Outro;");
                Console.Write("Digite sua opção: ");
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
                else
                {
                    Console.WriteLine("Escolha uma opção válida.");
                }
                nota.TipoImposto = escolhaImpostoUsuario;
            }

            while (verificarValorImposto == false)
            {
                Console.Write("Insira o valor do imposto: ");
                verificarValorImposto = decimal.TryParse(Console.ReadLine(), out valorImpostoInserido);
                if (verificarValorImposto == false)
                {
                    Console.WriteLine("Insira um valor de produto válido.");
                }
            }
            nota.ValorTotalImposto = valorImpostoInserido;

            return nota;

        }
    }

}