using DevInDocuments.Entities.Validacoes;
using DevInDocuments.Entities.Static.Cadastros;
using DevInDocuments.Entities.Enumerators;

namespace DevInDocuments.Entities
{
    public abstract class DevInDocuments
    {
        protected DateTime _dataCadastro;
        internal string _codigoDocumento;
        public DateTime DataAlteracao { get; set; }
        public string NomeEstabelecimento { get; set; }
        public string CNPJ { get; set; }
        public Status StatusDocumento { get; set; }
        public string IdentificacaoFuncionario { get; set; }

        public DevInDocuments(
            string nomeEstabelecimento,
            string cnpj,
            string identificacaoFuncionario)
        {
            _codigoDocumento = Guid.NewGuid().ToString();
            NomeEstabelecimento = nomeEstabelecimento;
            CNPJ = cnpj;
            _dataCadastro = DateTime.Now;
            DataAlteracao = DateTime.Now;
            IdentificacaoFuncionario = identificacaoFuncionario;
        }
        public DevInDocuments(
            string nomeEstabelecimento,
            string cnpj,
            string identificacaoFuncionario,
            Status statusDocumento,
            DateTime dataAlteracao)
        {
            _codigoDocumento = Guid.NewGuid().ToString();
            NomeEstabelecimento = nomeEstabelecimento;
            CNPJ = cnpj;
            _dataCadastro = DateTime.Now;
            DataAlteracao = DateTime.Now;
            IdentificacaoFuncionario = identificacaoFuncionario;
            StatusDocumento = statusDocumento;
        }


        public virtual void CadastrarDocumento(string funcionario) { }
        public virtual void ListarDocumento() { }
        public virtual void AlterarDocumento(string funcionario) { }
        public void AlterarStatus()
        {
            var documentoEscolhido = ValidacaoCodigo.Codigo();
            var documentoEncontrado = Listas.Lista.Where(x => x._codigoDocumento.StartsWith(documentoEscolhido)).First();
            Console.WriteLine("Documento escolhido para alteração:" +
                             $"\n{documentoEncontrado}");
            Console.WriteLine("Insira o novo status: ");
            documentoEncontrado.StatusDocumento = CadastrarStatusDocumento.CadastroStatus();
            documentoEncontrado.DataAlteracao = DateTime.Now;
            Console.WriteLine(documentoEncontrado);
            Console.WriteLine(@$"Documento alterado com sucesso!");




        }
    }
}