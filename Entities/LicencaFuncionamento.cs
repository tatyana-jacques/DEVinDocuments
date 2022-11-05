using DevInDocuments.Entities.Exceptions;
using DevInDocuments.Entities.Static;

namespace DevInDocuments.Entities
{
    public class LicencaFuncionamento : DevInDocuments
    {
        public string Endereco { get; set; }
        public string AreaAtuacao { get; set; }

        public LicencaFuncionamento(
           string nomeEstabelecimento,
           string cnpj,
           string identificacaoFuncionario,
           string endereco,
           string areaAtuacao,
           string statusDocumento
           ) :
           base(nomeEstabelecimento, cnpj, identificacaoFuncionario, statusDocumento)
        {
            if (endereco == null)
            {
                throw new CampoNuloException("Insira um endereço válido.");
            }
            if (areaAtuacao == null)
            {
                throw new CampoNuloException("Insira uma área de atuação.");
            }

            Endereco = endereco;
            AreaAtuacao = areaAtuacao;
        }

        public override void CadastrarDocumento(string funcionario)
        {
            LicencaFuncionamento licenca = new LicencaFuncionamento(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
            licenca.IdentificacaoFuncionario = funcionario;
            Console.Clear();
            Listas.Lista.Add(CadastrarLicenca.CadastroLicenca(funcionario, licenca));
            Console.WriteLine(licenca);
            Console.WriteLine("Licença cadastrada com sucesso!");
            MenuPrincipal.MenuInicial(funcionario);
        }

        public override void ListarDocumento()
        {
            Console.Clear();
            Console.WriteLine("Lista de Licenças de Funcionamento: ");
            foreach (DevInDocuments x in Listas.Lista)
            {
                if (x.GetType() == typeof(LicencaFuncionamento))
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
                        if (x.GetType() == typeof(LicencaFuncionamento) && x.codigoDocumento.StartsWith(documentoEscolhido))
                        {
                            inserirCodigo = true;
                            Console.WriteLine($"Licença de Funcionamento escolhida: {x}");
                            Console.WriteLine("Insira os novos dados para o documento.");
                            var licenca = (LicencaFuncionamento)x;
                            licenca.NomeEstabelecimento = string.Empty;
                            licenca.CNPJ = string.Empty;
                            licenca.Endereco = string.Empty;

                            CadastrarLicenca.CadastroLicenca(funcionario, licenca);
                            Console.WriteLine(@$"Data de alteracao : {licenca.DataAlteracao}
                            Nota Fiscal alterada com sucesso!");

                        }
                    }
                }
            }

        }

        public override string ToString()
        {
            return
            @$"     =========================================================

            Dados da Licença de Funcionamento:
            Código do documento : {codigoDocumento};
            Data de cadastro : {dataCadastro};
            Status do documento: {StatusDocumento};
            Nome do Estabelecimento: {NomeEstabelecimento};
            CNPJ: {CNPJ};
            Identificação do Funcionário: {IdentificacaoFuncionario};
            Endereço: {Endereco};
            Área de Atuação: {AreaAtuacao}
            ";

        }


    }

}

