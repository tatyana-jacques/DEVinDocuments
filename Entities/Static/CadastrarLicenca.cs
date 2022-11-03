
namespace DevInDocuments.Entities.Static
{
    public static class CadastrarLicenca
    {
        public static void cadastroLicenca(string funcionario){

            LicencaFuncionamento licenca = new LicencaFuncionamento(string.Empty,
                        cnpj: string.Empty,
                        identificacaoFuncionario: string.Empty,
                        endereco: string.Empty,
                        areaAtuacao: string.Empty,
                        statusDocumento: string.Empty);
                        licenca.IdentificacaoFuncionario = funcionario;

            //Set nome
            while (licenca.NomeEstabelecimento == string.Empty)
            {
                Console.Write("Insira o nome do estabelecimento: ");
                licenca.NomeEstabelecimento = Console.ReadLine() ?? string.Empty;
            }

            //Set CNPJ
            while (licenca.CNPJ == string.Empty)
            {
                Console.Write("Insira o CNPJ do estabelecimento: ");
                licenca.CNPJ = Console.ReadLine() ?? string.Empty;
            }
            //Set Endereço
            while (licenca.Endereco == string.Empty)
            {
                Console.Write("Insira o Endereço do estabelecimento: ");
                licenca.Endereco = Console.ReadLine() ?? string.Empty;
            }

            //Set status
            licenca.StatusDocumento = CadastrarStatusDocumento.CadastroStatus().ToString();

             //Set area atuacao
             MenuAreaAtuacao.AreaAtuacao();
             licenca.AreaAtuacao = MenuAreaAtuacao.AreaAtuacao().ToString();

             licenca.CadastrarDocumento(licenca);
             MenuPrincipal.MenuInicial(funcionario);
        }


   
    }
}