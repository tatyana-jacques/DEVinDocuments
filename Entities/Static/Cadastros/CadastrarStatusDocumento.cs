using DevInDocuments.Entities.Enumerators;
namespace DevInDocuments.Entities.Static.Cadastros
{
    public static class CadastrarStatusDocumento
    {
        public static Status CadastroStatus()
        {
            bool escolhaStatus = false;
            Status enumStatus = Status.Tramitando;
            while (escolhaStatus == false)
            {

                Console.WriteLine(@$"Selecione o status: 
                        1-Ativo;
                        2-Em tramitação;
                        3-Suspenso.");

                Console.Write("Digite sua opção: ");

                var escolhaUsuario = Console.ReadLine() ?? string.Empty;

                switch (escolhaUsuario)
                {
                    case "1":
                        enumStatus = Status.Ativo;
                        escolhaStatus = true;
                        break;

                    case "2":
                        enumStatus = Status.Tramitando;
                        escolhaStatus = true;
                        break;

                    case "3":
                        enumStatus = Status.Suspenso;
                        escolhaStatus = true;
                        break;
                    default:
                        Console.WriteLine("Escolha uma opção válida.");
                        break;

                }

            }
            return enumStatus;

        }
    }
}