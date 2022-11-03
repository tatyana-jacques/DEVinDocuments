using DevInDocuments.Entities.Exceptions;
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
           string finalidade,
           string statusDocumento
           ) :
           base(nomeEstabelecimento, cnpj, identificacaoFuncionario, statusDocumento)
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
           string statusDocumento,
           DateTime dataExpiracao,
           string[] testemunhas
           ) :
           base(nomeEstabelecimento, cnpj, identificacaoFuncionario, statusDocumento)
        {
            if (finalidade == null)
            {
                throw new CampoNuloException("Insira um endereço válido.");
            }


            Finalidade = finalidade;
            DataExpiracao = dataExpiracao;
            Testemunhas = testemunhas;

        }
        public override void CadastrarDocumento(DevInDocuments documento)
        {
            //lista.Add(documento);
        }

        public override void ListarDocumento()
        {
             foreach (Contrato x in Listas.ListaContratos)
            {
                Console.WriteLine(x);
            }
        }

        public override void AlterarDocumento()
        {

        }

          public override string ToString()
        {
            return @$"Dados do contrato:
            Código do documento : {codigoDocumento};
            Data de cadastro : {dataCadastro};
            Status do documento: {StatusDocumento};
            Nome do Estabelecimento: {NomeEstabelecimento};
            CNPJ: {CNPJ};
            Identificação do Funcionário: {IdentificacaoFuncionario};
            Finalidade: {Finalidade};
            Data de expiração: {DataExpiracao.ToString ("dd/MM/yyyy")}
            Testemunhas: {string.Join(", ", Testemunhas)}
            =========================================================";
        }


    }
}