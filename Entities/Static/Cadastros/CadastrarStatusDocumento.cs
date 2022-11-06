using DevInDocuments.Entities.Enumerators;
namespace DevInDocuments.Entities.Static.Cadastros
{
    public static class CadastrarStatusDocumento
    {
        public static Status CadastroStatus()
        {
            Status enumStatus = Status.Tramitando;
          
                Console.WriteLine(
                    "==================================================================================" +
                    "\nSelecione o status:" +  
                    "\n1-Ativo;" + 
                    "\n2-Em tramitação;" + 
                    "\n3-Suspenso.");

                Console.Write("Digite sua opção: ");

                var escolhaUsuario = Console.ReadLine() ?? string.Empty;

                switch (escolhaUsuario)
                {
                    case "1":
                        enumStatus = Status.Ativo;
                        break;
                    case "2":
                        enumStatus = Status.Tramitando;
                        break;
                    case "3":
                        enumStatus = Status.Suspenso;
                        break;
                    default:
                        Console.WriteLine("Escolha uma opção de status válida.");
                        CadastroStatus();
                        break;
                }

            return enumStatus;
        }
    }
}