using DevInDocuments.Entities.Enums;
using DevInDocuments.Entities.Exceptions;
namespace DevInDocuments.Entities
{
    public class Documento
    {

        private DateTime dataCadastro;
        public string CodigoDocumento { get; set; }
        
        protected DateTime DataAlteracao { get; set; }
        public string NomeEstabelecimento { get; set; }
        public string CNPJ { get; set; }
        public StatusDocumento Status { get; set; }

        public int IdentificacaoFuncionario { get; set; }

        // public Documento(
        //     int codigoDocumento,
        //     string nomeEstabelecimento,
        //     string cnpj,
        //     StatusDocumento status,
        //     int identificacaoFuncionario)
        // {
        //     if (nomeEstabelecimento == null)
        //     {
        //         throw new CampoNuloException("Insira um nome de estabelecimento válido.");
        //     }
        //     if (cnpj == null)
        //     {
        //         throw new CampoNuloException("Insira um nome CNPJ válido.");
        //     }
        //     CodigoDocumento = codigoDocumento;
        //     NomeEstabelecimento = nomeEstabelecimento;
        //     CNPJ = cnpj;
        //     dataCadastro = DateTime.Now;
        //     DataAlteracao = DateTime.Now;
        //     IdentificacaoFuncionario = identificacaoFuncionario;
        // }

        public void CadastrarDocumento(Documento documento)
        {
            //lista.Add(documento);
        }

        public virtual void ListarDocumento()
        {
            Console.WriteLine(@$"Código do documento: {CodigoDocumento};
        Data do Cadastro: {dataCadastro};
        Data da última alteração: {DataAlteracao};
        Nome do Estabelecimento: {NomeEstabelecimento};
        CNPJ: {CNPJ};
        Status do documento: {Status};
        IdentificacaoFuncionario: {IdentificacaoFuncionario}.");
        }

        public virtual void AlterarItensDocumento(
            string nomeEstabelecimento, 
            string cnpj, 
            int identificacaoFuncionario)
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
        public void AlterarStatus(StatusDocumento status)
        {
            Status = status;

        }



    }



}