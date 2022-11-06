using DevInDocuments.Entities.Enumerators;
using DevInDocuments.Entities.Static.Cadastros;
using DevInDocuments.Entities.Static.Menus;

namespace DevInDocuments.Entities
{
    public class LicencaFuncionamento : DevInDocuments
    {

        public string Endereco { get; set; }
        public AreaAtuacao AreaAtuacao { get; set; }

        public LicencaFuncionamento(
           string nomeEstabelecimento,
           string cnpj,
           string identificacaoFuncionario,
           string endereco
           ) :
           base(nomeEstabelecimento, cnpj, identificacaoFuncionario)
        {

            Endereco = endereco;
        }
        public LicencaFuncionamento(
           string nomeEstabelecimento,
           string cnpj,
           string identificacaoFuncionario,
           string endereco,
           AreaAtuacao areaAtuacao,
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
            LicencaFuncionamento licenca = new LicencaFuncionamento(string.Empty, string.Empty, string.Empty, string.Empty);
            licenca.IdentificacaoFuncionario = funcionario;
            licenca.StatusDocumento = CadastrarStatusDocumento.CadastroStatus();
            Listas.Lista.Add(CadastrarLicenca.CadastroLicenca(licenca));
            Console.WriteLine(licenca);
            Console.WriteLine(
                "=================================================================================="+
                "\n Licença cadastrada com sucesso!");
            MenuPrincipal.MenuInicial(funcionario);
        }

        public override void ListarDocumento()
        {
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

                            CadastrarLicenca.CadastroLicenca(licenca);
                            Console.WriteLine(@$"Data de alteracao : {licenca.DataAlteracao}
                            Licença de Funcionamento alterada com sucesso!");

                        }
                    }
                }
            }

        }

        public override string ToString()
        {
            return
           "=================================================================================="+
           $" \n Dados da Licença de Funcionamento:" + 
           $" \n Código do documento: {_codigoDocumento};"+
           $" \n Data de cadastro: {_dataCadastro};" + 
           $" \n Data da última alteracao: {DataAlteracao};" + 
           $" \n Status do documento: {StatusDocumento};" + 
           $" \n Nome do Estabelecimento: {NomeEstabelecimento};" +
           $" \n CNPJ: {CNPJ};" +
           $" \n Identificação do Funcionário: {IdentificacaoFuncionario};" + 
           $" \n Endereço: {Endereco};" +
           $" \n Área de Atuação: {AreaAtuacao}";

        }

    }

}

