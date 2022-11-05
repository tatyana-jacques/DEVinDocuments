using DevInDocuments.Entities.Exceptions;
using DevInDocuments.Entities.Static;

namespace DevInDocuments.Entities
{
    public abstract class DevInDocuments
    {
        protected DateTime dataCadastro;
        internal string codigoDocumento;
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

        public virtual void CadastrarDocumento(string funcionario)
        {

        }

        public virtual void ListarDocumento()
        {
            foreach (DevInDocuments x in Listas.Lista)
            {
                Console.WriteLine(x);
            }
        }

        public virtual void AlterarDocumento(string funcionario)
        {

        }
        public void AlterarStatus()
        {
            bool inserirCodigo = false;
            string documentoEscolhido = string.Empty;
            while (inserirCodigo == false)
            {
                Console.WriteLine();
                Console.WriteLine ("Lista de documentos disponíveis: ");
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
                        if (x.codigoDocumento.StartsWith(documentoEscolhido))
                        {
                            inserirCodigo = true;
                            Console.WriteLine($"Documento escolhido: {x}");
                            x.StatusDocumento = CadastrarStatusDocumento.CadastroStatus().ToString();
                            Console.WriteLine (x);
                            Console.WriteLine(@$"Data de alteracao : {x.DataAlteracao}
                            Documento alterado com sucesso!");

                        }
                    }
                }
            }

        }

    }
}