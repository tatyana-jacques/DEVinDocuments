using DevInDocuments.Entities.Exceptions;
using DevInDocuments.Entities.Static;
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

        public override void CadastrarDocumento(string funcionario)
        {
            NotaFiscal nota = new NotaFiscal(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
            nota.IdentificacaoFuncionario = funcionario;
            Console.Clear();
            Listas.Lista.Add(CadastrarNotaFiscal.CadastroNotaFiscal(funcionario, nota));
            Console.WriteLine("Nota cadastrada com sucesso!");
            Console.WriteLine(nota);
            MenuPrincipal.MenuInicial(funcionario);
        }

        public override void ListarDocumento()
        {
            Console.Clear();
            Console.WriteLine("Lista de Licenças de Funcionamento: ");
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

                Console.WriteLine("Digite os quatro primeiros dígitos do código do documento que deseja alterar: ");
                documentoEscolhido = Console.ReadLine() ?? string.Empty;
                if (documentoEscolhido.Length != 4)
                {
                    Console.WriteLine("Você deve inserir quatro caracteres!");
                }
                else
                {
                    foreach (DevInDocuments x in Listas.Lista)
                    {
                        if (x.GetType() == typeof(NotaFiscal) && x.codigoDocumento.StartsWith(documentoEscolhido))
                        {
                            inserirCodigo = true;
                            Console.WriteLine($"Nota Fiscal escolhida: {x}");
                            Console.WriteLine("Insira os novos dados para o documento.");
                            var nota = (NotaFiscal)x;
                            nota.NomeEstabelecimento = string.Empty;
                            nota.CNPJ = string.Empty;
                            nota.NomeProduto = string.Empty;
                            CadastrarNotaFiscal.CadastroNotaFiscal(funcionario, nota);
                            Console.WriteLine(@$"Data de alteracao : {nota.DataAlteracao}
                            Nota Fiscal alterada com sucesso!");

                        }
                    }
                }
            }


        }

        public override string ToString()
        {
            return
            @$"         =========================================================

            Dados da Nota Fiscal:
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
            ";

        }
    }


}