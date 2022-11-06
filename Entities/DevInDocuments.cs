using DevInDocuments.Entities.Exceptions;
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
            if (nomeEstabelecimento == null)
            {
                throw new CampoNuloException("Insira um nome de estabelecimento válido.");
            }
            if (cnpj == null)
            {
                throw new CampoNuloException("Insira um nome CNPJ válido.");
            }
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
            if (nomeEstabelecimento == null)
            {
                throw new CampoNuloException("Insira um nome de estabelecimento válido.");
            }
            if (cnpj == null)
            {
                throw new CampoNuloException("Insira um nome CNPJ válido.");
            }
            _codigoDocumento = Guid.NewGuid().ToString();
            NomeEstabelecimento = nomeEstabelecimento;
            CNPJ = cnpj;
            _dataCadastro = DateTime.Now;
            DataAlteracao = DateTime.Now;
            IdentificacaoFuncionario = identificacaoFuncionario;
            StatusDocumento = statusDocumento;
        }


        public virtual void CadastrarDocumento(string funcionario){}
        public virtual void ListarDocumento(){}
        public virtual void AlterarDocumento(string funcionario){}
        public void AlterarStatus()
        {
            bool inserirCodigo = false;
            string documentoEscolhido = string.Empty;
            while (inserirCodigo == false)
            {
                Console.WriteLine();
                Console.WriteLine("Lista de documentos disponíveis: ");
                Listas.ListarTodosDocumentos();
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
                        if (x._codigoDocumento.StartsWith(documentoEscolhido))
                        {
                            inserirCodigo = true;
                            Console.WriteLine($"Documento escolhido para alteração: {x}");
                            x.StatusDocumento = CadastrarStatusDocumento.CadastroStatus();
                            x.DataAlteracao = DateTime.Now;
                            Console.WriteLine(x);
                            Console.WriteLine(@$"Documento alterado com sucesso!");

                        }
                    }
                }
            }
        }
    }
}