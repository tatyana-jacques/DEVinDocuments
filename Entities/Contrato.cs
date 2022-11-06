using DevInDocuments.Entities.Validacoes;
using DevInDocuments.Entities.Static.Cadastros;
using DevInDocuments.Entities.Enumerators;
namespace DevInDocuments.Entities
{
    public class Contrato : DevInDocuments
    {
        public string Finalidade;
        public string[] Testemunhas = new string[2];
        public DateTime DataExpiracao { get; set; }

        public Contrato(
           string nomeEstabelecimento,
           string cnpj,
           string identificacaoFuncionario,
           string finalidade
           ) :
           base(nomeEstabelecimento, cnpj, identificacaoFuncionario)
        {
            Finalidade = finalidade;
        }
        public Contrato(
           string nomeEstabelecimento,
           string cnpj,
           string identificacaoFuncionario,
           string finalidade,
           Status statusDocumento,
           DateTime dataAlteracao,
           DateTime dataExpiracao,
           string[] testemunhas
           ) :
           base(nomeEstabelecimento, cnpj, identificacaoFuncionario, statusDocumento, dataAlteracao)
        {
            Finalidade = finalidade;
            DataExpiracao = dataExpiracao;
            Testemunhas = testemunhas;

        }
        public override void CadastrarDocumento(string funcionario)
        {
            Contrato contrato = new Contrato(string.Empty, string.Empty, string.Empty, string.Empty);
            contrato.IdentificacaoFuncionario = funcionario;
            contrato.StatusDocumento = CadastrarStatusDocumento.CadastroStatus();
            Listas.Lista.Add(CadastrarContrato.CadastroContrato(contrato));
            Console.WriteLine(
                "==================================================================================" +
                "\n Contrato Cadastrado com sucesso!");
        }

        public override void ListarDocumento()
        {
            foreach (DevInDocuments x in Listas.Lista)
            {
                if (x.GetType() == typeof(Contrato))
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
                var contratoEncontrado = Listas.Lista.Where(x => x._codigoDocumento.StartsWith(documentoEscolhido)).First();
                Console.WriteLine("Contrato escolhido:" +
                $"\n{contratoEncontrado}");
                Console.WriteLine("==================================================================================" +
                "\nInsira os novos dados para o documento.");
                var contrato = (Contrato)contratoEncontrado;
                contrato.NomeEstabelecimento = string.Empty;
                contrato.CNPJ = string.Empty;

                CadastrarContrato.CadastroContrato(contrato);
                Console.WriteLine(
                    "==================================================================================" +
                    "\nContrato alterado com sucesso!"+
                    $"\n{contrato}");
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
            "==================================================================================" +
            $"\nDados do contrato:" +
            $"\nCódigo do documento: {_codigoDocumento};" +
            $"\nData de cadastro: {_dataCadastro};" +
            $"\nData de alteracao: {DataAlteracao};" +
            $"\nStatus do documento: {StatusDocumento};" +
            $"\nNome do Estabelecimento: {NomeEstabelecimento};" +
            $"\nCNPJ: {CNPJ};" +
            $"\nIdentificação do Funcionário: {IdentificacaoFuncionario};" +
            $"\nFinalidade: {Finalidade};" +
            $"\nData de expiração: {DataExpiracao.ToString("dd/MM/yyyy")}" +
            $"\nTestemunhas: {string.Join(", ", Testemunhas)}";
        }

    }
}