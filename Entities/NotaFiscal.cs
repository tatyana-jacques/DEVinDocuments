using DevInDocuments.Entities.Static.Cadastros;
using DevInDocuments.Entities.Enumerators;
using DevInDocuments.Entities.Validacoes;
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
           var documentoEscolhido = ValidacaoCodigo.Codigo();
            try
            {
                var notaEncontrada = Listas.Lista.Where(x => x._codigoDocumento.StartsWith(documentoEscolhido)).First();
                Console.WriteLine("Nota Fiscal escolhida:" +
                $"\n{notaEncontrada}");
                Console.WriteLine("==================================================================================" +
                "\nInsira os novos dados para o documento.");
                var nota = (NotaFiscal)notaEncontrada;
                nota.NomeEstabelecimento = string.Empty;
                nota.CNPJ = string.Empty;
                nota.NomeProduto = string.Empty;
                CadastrarNotaFiscal.CadastroNotaFiscal(nota);
                Console.WriteLine(
                    "==================================================================================" +
                    "\nNota Fiscal alterada com sucesso!"+
                    $"\n{nota}");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Código inexistente!");
                AlterarDocumento(funcionario);
            }

        }

        public override string ToString()
        {
            return
            "=================================================================================="+
            $"\nDados da Nota Fiscal:" + 
            $"\nCódigo do documento: {_codigoDocumento};" + 
            $"\nData de cadastro: {_dataCadastro};" +
            $"\nData da última alteracao:  {DataAlteracao};" +
            $"\nStatus do documento: {StatusDocumento};" +
            $"\nNome do Estabelecimento: {NomeEstabelecimento};"+
            $"\nCNPJ: {CNPJ};" +
            $"\nIdentificação do Funcionário: {IdentificacaoFuncionario};" +
            $"\nNome do Produto: {NomeProduto};" +
            $"\nTipo do Imposto: {TipoImposto};" +
            $"\nValor total da nota: {ValorTotal.ToString("F2")};" +
            $"\nValor total do imposto: {ValorTotalImposto.ToString("F2")}.";
        }
    }



}