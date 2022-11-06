using DevInDocuments.Entities.Enumerators;
using DevInDocuments.Entities.Static.Cadastros;
using DevInDocuments.Entities.Static.Menus;
using DevInDocuments.Entities.Validacoes;

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
                "==================================================================================" +
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
            var documentoEscolhido = ValidacaoCodigo.Codigo();
            try
            {
                var licencaEncontrada = Listas.Lista.Where(x => x._codigoDocumento.StartsWith(documentoEscolhido)).First();
                Console.WriteLine("Licença escolhida:" +
                $"\n{licencaEncontrada}");
                Console.WriteLine("==================================================================================" +
                "\nInsira os novos dados para o documento.");
                var licenca = (LicencaFuncionamento)licencaEncontrada;
                licenca.NomeEstabelecimento = string.Empty;
                licenca.CNPJ = string.Empty;
                licenca.Endereco = string.Empty;
                CadastrarLicenca.CadastroLicenca(licenca);
                Console.WriteLine(
                    "==================================================================================" +
                    "\nLicença de Funcionamento alterada com sucesso!" +
                    $"\n{licenca}");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Código inexistente!");
                AlterarDocumento(funcionario);
            }
        }

        public override string ToString()
        {
            return
           "==================================================================================" +
           $"\nDados da Licença de Funcionamento:" +
           $"\nCódigo do documento: {_codigoDocumento};" +
           $"\nData de cadastro: {_dataCadastro};" +
           $"\nData da última alteracao: {DataAlteracao};" +
           $"\nStatus do documento: {StatusDocumento};" +
           $"\nNome do Estabelecimento: {NomeEstabelecimento};" +
           $"\nCNPJ: {CNPJ};" +
           $"\nIdentificação do Funcionário: {IdentificacaoFuncionario};" +
           $"\nEndereço: {Endereco};" +
           $"\nÁrea de Atuação: {AreaAtuacao}";
        }

    }

}

