using DevInDocuments.Entities.Exceptions;
namespace DevInDocuments.Entities
{
    public class NotaFiscal : DevInDocuments
    {
        public decimal ValorTotal { get; set; }
        public string NomeProduto { get; set; }
        public string TipoImposto { get; set; }
        public decimal ValorTotalImposto { get; set; }
        public NotaFiscal(
            string nomeEstabelecimento,
            string cnpj,
            string identificacaoFuncionario,
            string nomeProduto,
            string tipoImposto,
            string statusDocumento) :
        base(
             nomeEstabelecimento,
             cnpj,
             identificacaoFuncionario,
             statusDocumento)
        {
            if (nomeProduto == null)
            {
                throw new CampoNuloException("Insira um nome de produto válido.");
            }
            if (tipoImposto == null)
            {
                throw new CampoNuloException("Insira um nome de produto válido.");
            }
            NomeProduto = nomeProduto;
            TipoImposto = tipoImposto;

        }
        public NotaFiscal(
            string nomeEstabelecimento,
            string cnpj,
            string identificacaoFuncionario,
            string nomeProduto,
            string tipoImposto,
            string statusDocumento,
            decimal valorTotal,
            decimal valorTotalImposto) :
        base(
             nomeEstabelecimento,
             cnpj,
             identificacaoFuncionario,
             statusDocumento)
        {
            if (nomeProduto == null)
            {
                throw new CampoNuloException("Insira um nome de produto válido.");
            }
            if (tipoImposto == null)
            {
                throw new CampoNuloException("Insira um nome de produto válido.");
            }
            NomeProduto = nomeProduto;
            TipoImposto = tipoImposto;
            ValorTotal = valorTotal;
            ValorTotalImposto = valorTotalImposto;

        }

        public void CadastrarDocumento(NotaFiscal nota)
        {

            Listas.ListaNotasFiscais.Add(nota);
            Console.WriteLine("Documento cadastrado com sucesso!");
            Console.WriteLine(nota);

        }

        public override void ListarDocumento()
        {
            foreach (NotaFiscal x in Listas.ListaNotasFiscais)
            {
                Console.WriteLine(x);
            }
        }

        public void AlterarDocumento(NotaFiscal nota)
        {

            //Set nome
            while (nota.NomeEstabelecimento == string.Empty)
            {
                Console.Write("Insira o novo nome do estabelecimento: ");
                nota.NomeEstabelecimento = Console.ReadLine() ?? string.Empty;
            }

            //Set CNPJ
            while (nota.CNPJ == string.Empty)
            {
                Console.Write("Insira o novo CNPJ: ");
                nota.CNPJ = Console.ReadLine() ?? string.Empty;
            }
            
            //Set Produto
            while (nota.NomeProduto == string.Empty)
            {
                Console.WriteLine("Insira o novo nome de produto: ");
                nota.NomeProduto = Console.ReadLine() ?? string.Empty;
            }

            //Set valor produto
            Console.WriteLine("Insira o novo valor total do produto: ");
            bool verificarValorTotal =false;
            decimal valorTotalInserido=0;
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
            bool escolhaTipoImposto = false;
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
                else
                {
                    Console.WriteLine("Escolha uma opção válida.");
                }

                nota.TipoImposto = escolhaImpostoUsuario;

            }

            //Set valor do imposto
            bool verificarValorImposto = false;
            decimal valorImpostoInserido = 0;
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
            nota.DataAlteracao = DateTime.Now;

            Console.WriteLine(@$"Nota Fiscal alterada: {nota}
                Data de alteracao : {DataAlteracao}");

        }

        public override string ToString()
        {
            return @$"Dados da Nota Fiscal:
            Código do documento : {codigoDocumento};
            Data de cadastro : {dataCadastro};
            Status do documento: {StatusDocumento};
            Nome do Estabelecimento: {NomeEstabelecimento};
            CNPJ: {CNPJ};
            Identificação do Funcionário: {IdentificacaoFuncionario};
            Nome do Produto: {NomeProduto};
            Tipo do Imposto: {TipoImposto};
            Valor total da nota: {ValorTotal.ToString("F2")};
            Valor total do imposto: {ValorTotalImposto.ToString("F2")}
            =========================================================";

        }
    }


}