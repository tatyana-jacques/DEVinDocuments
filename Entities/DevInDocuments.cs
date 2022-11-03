using DevInDocuments.Entities.Exceptions;

namespace DevInDocuments.Entities
{
    public class DevInDocuments
    {
        protected DateTime dataCadastro;
        protected string codigoDocumento;
        public DateTime DataAlteracao { get; set; }
        public string NomeEstabelecimento { get; set; }
        public string CNPJ { get; set; }
        public string StatusDocumento { get; set; }
        public string IdentificacaoFuncionario { get; set; }

        public DevInDocuments(
            string nomeEstabelecimento,
            string cnpj,
            string identificacaoFuncionario,
            string statusDocumento)
        {
            if (nomeEstabelecimento == null)
            {
                throw new CampoNuloException("Insira um nome de estabelecimento válido.");
            }
            if (cnpj == null)
            {
                throw new CampoNuloException("Insira um nome CNPJ válido.");
            }
            if (statusDocumento == null)
            {
                throw new CampoNuloException("Escolha o status do documento.");
            }
            codigoDocumento = Guid.NewGuid().ToString();
            NomeEstabelecimento = nomeEstabelecimento;
            CNPJ = cnpj;
            dataCadastro = DateTime.Now;
            DataAlteracao = DateTime.Now;
            IdentificacaoFuncionario = identificacaoFuncionario;
            StatusDocumento = statusDocumento;
        }

        public virtual void CadastrarDocumento(DevInDocuments documento)
        {
        }

        public virtual void ListarDocumento()
        {
        }

        public virtual void AlterarItensDocumento(
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
        public void AlterarStatus(string novoStatus)
        {


        }

    }
}