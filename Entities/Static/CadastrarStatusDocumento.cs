namespace DevInDocuments.Entities.Static
{
    public static class CadastrarStatusDocumento
    {
        public static string CadastroStatus()
        {
            var escolhaStatus = string.Empty;
            while (escolhaStatus == string.Empty)
            {

                Console.WriteLine(@$"Selecione o número equivalente ao status do documento: 
                        1-Ativo;
                        2-Em transição;
                        3-Suspenso.");

                var escolhaUsuario = Console.ReadLine() ?? string.Empty;

                if (escolhaUsuario == "1")
                {
                    escolhaStatus = "Ativo";
                }
                else if (escolhaUsuario == "2")
                {     
                    escolhaStatus = "Em transição.";

                }
                else if (escolhaUsuario == "3")
                {
                    escolhaStatus = "Suspenso";
                }
                else
                {
                    return "Escolha uma opção válida.";
                }

            }
            return escolhaStatus;

        }

    }
}