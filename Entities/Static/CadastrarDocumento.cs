using DevInDocuments.Entities.Exceptions;
namespace DevInDocuments.Entities.Static
{
    public static class CadastrarDocumento
    {
        public static void CadastroDocumento(string funcionario)
        {
            bool escolhaTipoDocumento = false;

            while (escolhaTipoDocumento == false)
            {
                try
                {
                    Console.WriteLine(@$"Selecione o número correspondente ao tipo de documento que deseja criar: 
                        1- Nota Fiscal;
                        2- Licença de Funcionamento.
                        3- Contrato.");
                    var escolhaUsuarioDocumento = Console.ReadLine();

                    //O documento é nota fiscal
                    if (escolhaUsuarioDocumento == "1")
                    {
                        CadastrarNotaFiscal.CadastroNotaFiscal(funcionario);
                        escolhaTipoDocumento = true;
                    }
                    if (escolhaUsuarioDocumento == "2")
                    {
                        CadastrarLicenca.cadastroLicenca(funcionario);
                        escolhaTipoDocumento = true;
                    }

                    else 
                    {
                        throw new OpcaoInexistenteException();
                    }

                }
                catch(OpcaoInexistenteException){}
            }
        }
    }
}