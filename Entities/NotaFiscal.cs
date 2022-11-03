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

        
        public void AlterarDocumento(NotaFiscal nota){
    
                Console.WriteLine("Insira o novo nome de estabelecimento: ");
                nota.NomeEstabelecimento = Console.ReadLine() ?? string.Empty;
                Console.WriteLine($"Nota Fiscal alterada: {nota}");

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