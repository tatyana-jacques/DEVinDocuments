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
            contrato.StatusDocumento = CadastrarStatusDocumento.CadastroStatus();
            Listas.Lista.Add(CadastrarContrato.CadastroContrato(funcionario, contrato));
            Console.WriteLine("Contrato Cadastrado com sucesso!");
        }

        public override void ListarDocumento()
        {
            Console.WriteLine("Lista de Contratos: ");
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
            bool inserirCodigo = false;
            string documentoEscolhido = string.Empty;
            while (inserirCodigo == false)
            {

                Console.Write("Digite os quatro primeiros caracteres do código do Contrato que deseja alterar: ");
                documentoEscolhido = Console.ReadLine() ?? string.Empty;
                if (documentoEscolhido.Length != 4)
                {
                    Console.WriteLine("Você deve inserir quatro caracteres!");
                }
                else
                {
                    foreach (DevInDocuments x in Listas.Lista)
                    {
                        if (x.GetType() == typeof(Contrato) && x._codigoDocumento.StartsWith(documentoEscolhido))
                        {
                            inserirCodigo = true;
                            Console.WriteLine($"Contrato escolhido: {x}");
                            Console.WriteLine("Insira os novos dados para o documento.");
                            var contrato = (Contrato)x;
                            contrato.NomeEstabelecimento = string.Empty;
                            contrato.CNPJ = string.Empty;

                            CadastrarContrato.CadastroContrato(funcionario, contrato);
                            Console.WriteLine(@$"Data de alteracao : {contrato.DataAlteracao}
                            Nota Fiscal alterada com sucesso!");

                        }
                    }
                }
            }

        }

        public override string ToString()
        {
            return
            @$"
            ==================================================================================

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