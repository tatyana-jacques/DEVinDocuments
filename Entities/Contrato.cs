using DevInDocuments.Entities.Exceptions;
namespace DevInDocuments.Entities
{
    public class Contrato : DevInDocuments
    {
        public string Finalidade;
        public string [] Testemunhas = new string [2];
        public DateTime DataExpiração {get;set;}

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
           string [] testemunhas
           ) :
           base(nomeEstabelecimento, cnpj, identificacaoFuncionario, statusDocumento)
        {
            if (finalidade == null)
            {
                throw new CampoNuloException("Insira um endereço válido.");
            }


            Finalidade = finalidade;
            DataExpiração = dataExpiracao;
            Testemunhas = testemunhas;
           
        }
        public override void CadastrarDocumento(DevInDocuments documento)
        {
            //lista.Add(documento);
        }

        public override void ListarDocumento()
        {
        }

        public override void AlterarItensDocumento(
            string nomeEstabelecimento,
            string cnpj,
            string identificacaoFuncionario)
        {
            if (nomeEstabelecimento == null)
            {
                throw new CampoNuloException("Insira um nome de estabelecimento válido.");
            }
            if (cnpj == null)
            {
                throw new CampoNuloException("Insira um nome de estabelecimento válido.");
            }
            NomeEstabelecimento = nomeEstabelecimento;
            CNPJ = cnpj;
            DataAlteracao = DateTime.Now;
            IdentificacaoFuncionario = identificacaoFuncionario;
        }

    }
}