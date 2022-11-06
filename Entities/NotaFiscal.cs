using DevInDocuments.Entities.Static.Cadastros;
using DevInDocuments.Entities.Enumerators;
namespace DevInDocuments.Entities
{
    public class NotaFiscal : DevInDocuments
    {
        public decimal ValorTotal { get; set; }
        public string NomeProduto { get; set; }
        public  TipoImposto TipoImposto { get; set; }
        public decimal ValorTotalImposto { get; set; }
        public NotaFiscal(
            string nomeEstabelecimento,
            string cnpj,
            string identificacaoFuncionario,
            string nomeProduto) :
        base(
             nomeEstabelecimento,
             cnpj,
             identificacaoFuncionario)
        {

            NomeProduto = nomeProduto;

        }
        public NotaFiscal(
            string nomeEstabelecimento,
            string cnpj,
            string identificacaoFuncionario,
            DateTime dataAlteracao,
            string nomeProduto,
            TipoImposto tipoImposto,
            Status statusDocumento,
            decimal valorTotal,
            decimal valorTotalImposto) :
        base(
             nomeEstabelecimento,
             cnpj,
             identificacaoFuncionario,
             statusDocumento,
             dataAlteracao)
        {
            NomeProduto = nomeProduto;
            TipoImposto = tipoImposto;
            ValorTotal = valorTotal;
            ValorTotalImposto = valorTotalImposto;

        }

        public override void CadastrarDocumento(string funcionario)
        {
            NotaFiscal nota = new NotaFiscal(string.Empty, string.Empty, string.Empty, string.Empty);
            nota.IdentificacaoFuncionario = funcionario;
            nota.StatusDocumento = CadastrarStatusDocumento.CadastroStatus();
            Listas.Lista.Add(CadastrarNotaFiscal.CadastroNotaFiscal(nota));
            Console.WriteLine("Nota cadastrada com sucesso!");
            Console.WriteLine(nota);
        }

        public override void ListarDocumento()
        {
            foreach (DevInDocuments x in Listas.Lista)
            {
                if (x.GetType() == typeof(NotaFiscal))
                {
                    Console.WriteLine(x);
                }
            }
        }

        public override void AlterarDocumento(string funcionario)
        {
            bool inserirCodigo = false;
            string documentoEscolhido = string.Empty;
            while (inserirCodigo == false)
            {
                Console.Write("Digite os quatro primeiros caracteres do código da Nota Fiscal que deseja alterar: ");
                documentoEscolhido = Console.ReadLine() ?? string.Empty;
                if (documentoEscolhido.Length != 4)
                {
                    Console.WriteLine("Você deve inserir quatro caracteres!");
                }
                else
                {
                    foreach (DevInDocuments x in Listas.Lista)
                    {
                        if (x.GetType() == typeof(NotaFiscal) && x._codigoDocumento.StartsWith(documentoEscolhido))
                        {
                            inserirCodigo = true;
                            Console.WriteLine($"Nota Fiscal escolhida: {x}");
                            Console.WriteLine("Insira os novos dados para o documento.");
                            var nota = (NotaFiscal)x;
                            nota.NomeEstabelecimento = string.Empty;
                            nota.CNPJ = string.Empty;
                            nota.NomeProduto = string.Empty;
                            CadastrarNotaFiscal.CadastroNotaFiscal(nota);
                            Console.WriteLine(
                                "=================================================================================="+
                                "\n Nota Fiscal alterada com sucesso!");

                        }
                    }
                }
            }
        }

        public override string ToString()
        {
            return
            "=================================================================================="+
            $" \n Dados da Nota Fiscal:" + 
            $" \n Código do documento: {_codigoDocumento};" + 
            $" \n Data de cadastro: {_dataCadastro};" +
            $" \n Data da última alteracao:  {DataAlteracao};" +
            $" \n Status do documento: {StatusDocumento};" +
            $" \n Nome do Estabelecimento: {NomeEstabelecimento};"+
            $" \n CNPJ: {CNPJ};" +
            $" \n Identificação do Funcionário: {IdentificacaoFuncionario};" +
            $" \n Nome do Produto: {NomeProduto};" +
            $" \n Tipo do Imposto: {TipoImposto};" +
            $" \n Valor total da nota: {ValorTotal.ToString("F2")};" +
            $" \n Valor total do imposto: {ValorTotalImposto.ToString("F2")}.";
        }
    }



}