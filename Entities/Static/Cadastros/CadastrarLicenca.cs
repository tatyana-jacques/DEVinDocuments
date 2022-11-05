
namespace DevInDocuments.Entities.Static
{
    public static class CadastrarLicenca
    {
        public static LicencaFuncionamento CadastroLicenca(string funcionario, LicencaFuncionamento licenca){

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
             licenca.AreaAtuacao = MenuAreaAtuacao.AreaAtuacao().ToString();

             return licenca;
        }


    }
}