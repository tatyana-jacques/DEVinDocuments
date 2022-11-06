
namespace DevInDocuments.Entities.Static.Cadastros
{
    public class CadastrarContrato
    {
        public static Contrato CadastroContrato(string funcionario, Contrato contrato)
        {
            bool verificarData = false;
            contrato.Testemunhas[0] = string.Empty;
            contrato.Testemunhas[1] = string.Empty;

            while (contrato.NomeEstabelecimento == string.Empty)
            {
                Console.Write("Insira o nome do estabelecimento: ");
                contrato.NomeEstabelecimento = Console.ReadLine() ?? string.Empty;
            }

            while (contrato.CNPJ == string.Empty)
            {
                Console.Write("Insira o CNPJ do estabelecimento: ");
                contrato.CNPJ = Console.ReadLine() ?? string.Empty;
            }

            var dataExpiracao = new DateTime();

            while (contrato.Finalidade == string.Empty)
            {
                Console.Write("Insira a finalidade do contrato: ");
                contrato.Finalidade = Console.ReadLine() ?? string.Empty;

            }
            while (contrato.Testemunhas[0] == string.Empty || contrato.Testemunhas[1] == string.Empty)
            {
                Console.WriteLine("Insira duas testemunhas para o contrato: ");
                Console.Write ("Testemunha 01: ");
                contrato.Testemunhas[0] = Console.ReadLine() ?? string.Empty;
                Console.Write ("Testemunha 02: ");
                contrato.Testemunhas[1] = Console.ReadLine() ?? string.Empty;
            }

            while (verificarData == false)
            {
                Console.Write("Insira a data de expiração do contrato no formato (dd/MM/yyyy): ");
                verificarData = DateTime.TryParse(Console.ReadLine(), out dataExpiracao);
                contrato.DataExpiracao = dataExpiracao;
            }
            contrato.DataAlteracao = DateTime.Now;

            Console.WriteLine(contrato);
            return contrato;

        }
    }
}
