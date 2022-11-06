using DevInDocuments.Entities.Exceptions;
using DevInDocuments.Entities.Static.Cadastros;
using DevInDocuments.Entities.Static.Menus;
using DevInDocuments.Entities.Enumerators;

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
           string areaAtuacao
           ) :
           base(nomeEstabelecimento, cnpj, identificacaoFuncionario)
        {

            Endereco = endereco;
            AreaAtuacao = areaAtuacao;
        }
        public LicencaFuncionamento(
           string nomeEstabelecimento,
           string cnpj,
           string identificacaoFuncionario,
           string endereco,
           string areaAtuacao,
           Status statusDocumento,
           DateTime dataAlteracao
           ) :
           base(nomeEstabelecimento, cnpj, identificacaoFuncionario, statusDocumento, dataAlteracao)
        {
            Endereco = endereco;
            AreaAtuacao = areaAtuacao;
        }

        public override void CadastrarDocumento(string funcionario)
        {
            LicencaFuncionamento licenca = new LicencaFuncionamento(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);
            licenca.IdentificacaoFuncionario = funcionario;
            licenca.StatusDocumento = CadastrarStatusDocumento.CadastroStatus();
            Listas.Lista.Add(CadastrarLicenca.CadastroLicenca(funcionario, licenca));
            Console.WriteLine(licenca);
            Console.WriteLine( @$"
            =========================================================
            Licença cadastrada com sucesso!");
            MenuPrincipal.MenuInicial(funcionario);
        }

        public override void ListarDocumento()
        {
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

                Console.Write("Digite os quatro primeiros caracteres do código da Licença que deseja alterar: ");
                documentoEscolhido = Console.ReadLine() ?? string.Empty;
                if (documentoEscolhido.Length != 4)
                {
                    Console.WriteLine("Você deve inserir quatro caracteres!");
                }
                else
                {
                    foreach (DevInDocuments x in Listas.Lista)
                    {
                        if (x.GetType() == typeof(LicencaFuncionamento) && x._codigoDocumento.StartsWith(documentoEscolhido))
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
            @$"==================================================================================

            Dados da Licença de Funcionamento:
            Código do documento: {_codigoDocumento};
            Data de cadastro: {_dataCadastro};
            Data da última alteracao: {DataAlteracao};
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

