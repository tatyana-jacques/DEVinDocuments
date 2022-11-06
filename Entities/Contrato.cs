using DevInDocuments.Entities.Exceptions;
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
            if (finalidade == null)
            {
                throw new CampoNuloException("Insira um endereço válido.");
            }
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
            if (finalidade == null)
            {
                throw new CampoNuloException("Insira um endereço válido.");
            }

            Finalidade = finalidade;
            DataExpiracao = dataExpiracao;
            Testemunhas = testemunhas;

        }
        public override void CadastrarDocumento(string funcionario)
        {
            Contrato contrato = new Contrato(string.Empty, string.Empty, string.Empty, string.Empty);
            contrato.IdentificacaoFuncionario = funcionario;
            Listas.Lista.Add(CadastrarContrato.CadastroContrato(funcionario, contrato));
            Console.WriteLine("Contrato Cadastrado com sucesso!");
        }

        public override void ListarDocumento()
        {
            Console.WriteLine("Lista de Licenças de Funcionamento: ");
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

        }

        public override string ToString()
        {
            return
            @$"==================================================================================

            Dados do contrato:
            Código do documento: {_codigoDocumento};
            Data de cadastro: {_dataCadastro};
            Data de alteracao: {DataAlteracao};
            Status do documento: {StatusDocumento};
            Nome do Estabelecimento: {NomeEstabelecimento};
            CNPJ: {CNPJ};
            Identificação do Funcionário: {IdentificacaoFuncionario};
            Finalidade: {Finalidade};
            Data de expiração: {DataExpiracao.ToString("dd/MM/yyyy")}
            Testemunhas: {string.Join(", ", Testemunhas)}
            ";
        }

    }
}