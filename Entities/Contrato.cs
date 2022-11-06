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
                var identidadeEncontrada = Listas.Lista.Where(x => x._codigoDocumento.StartsWith(documentoEscolhido)).First();
                Console.WriteLine("Contrato escolhido:" +
                $" \n {identidadeEncontrada}");
                Console.WriteLine("==================================================================================" +
                "\n Insira os novos dados para o documento.");
                var contrato = (Contrato)identidadeEncontrada;
                contrato.NomeEstabelecimento = string.Empty;
                contrato.CNPJ = string.Empty;

                CadastrarContrato.CadastroContrato(contrato);
                Console.WriteLine(
                    "==================================================================================" +
                    "\n Contrato alterado com sucesso!");
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
            $" \n Dados do contrato:" +
            $" \n Código do documento: {_codigoDocumento};" +
            $" \n Data de cadastro: {_dataCadastro};" +
            $" \n Data de alteracao: {DataAlteracao};" +
            $" \n Status do documento: {StatusDocumento};" +
            $" \n Nome do Estabelecimento: {NomeEstabelecimento};" +
            $" \n CNPJ: {CNPJ};" +
            $" \n Identificação do Funcionário: {IdentificacaoFuncionario};" +
            $" \n Finalidade: {Finalidade};" +
            $" \n Data de expiração: {DataExpiracao.ToString("dd/MM/yyyy")}" +
            $" \n Testemunhas: {string.Join(", ", Testemunhas)}";
        }

    }
}