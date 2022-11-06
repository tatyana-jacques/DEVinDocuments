
namespace DevInDocuments.Entities.Static.Cadastros
{
    public static class CadastrarLicenca
    {
        public static LicencaFuncionamento CadastroLicenca(LicencaFuncionamento licenca){

            while (licenca.NomeEstabelecimento == string.Empty)
            {
                Console.Write("Insira o nome do estabelecimento: ");
                licenca.NomeEstabelecimento = Console.ReadLine() ?? string.Empty;
            }

            while (licenca.CNPJ == string.Empty)
            {
                Console.Write("Insira o CNPJ do estabelecimento: ");
                licenca.CNPJ = Console.ReadLine() ?? string.Empty;
            }

            while (licenca.Endereco == string.Empty)
            {
                Console.Write("Insira o Endereço do estabelecimento: ");
                licenca.Endereco = Console.ReadLine() ?? string.Empty;
            }

             licenca.AreaAtuacao = MenuAreaAtuacao.EscolhaAreaAtuacao();
             licenca.DataAlteracao = DateTime.Now;

             return licenca;
        }


    }
}