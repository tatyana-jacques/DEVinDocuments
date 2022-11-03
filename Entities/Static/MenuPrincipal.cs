using DevInDocuments.Entities.Static;
using DevInDocuments.Entities.Exceptions;

namespace DevInDocuments.Entities
{
    public static class MenuPrincipal
    {

        public static void MenuInicial(string funcionario)
        {
            bool entrarMenuInicial = false;
            string funcionarioOperando = funcionario;


            while (entrarMenuInicial == false)
            {
                try
                {

                    Console.WriteLine(@$"Insira o número da operação que deseja fazer:
                1- Cadastrar documento;
                2-Listar documento;
                3-Alterar documento;
                4-Alterar status do documento;
                5-Relatórios;
                6-Sair do sistema.");

                    var escolhaMenuInicial = Console.ReadLine();

                    //Cadastrar documento
                    if (escolhaMenuInicial == "1")
                    {

                        CadastrarDocumento.CadastroDocumento(funcionarioOperando);
                        entrarMenuInicial=true;

                    }

                    //Editar documento
                    if (escolhaMenuInicial == "2")
                    {
                        MenuListarDocumentos.EscolherListaDocumentos(funcionarioOperando);
                         entrarMenuInicial=true;

                    }

                    //Sair do programa
                    if (escolhaMenuInicial == "6")
                    {
                        entrarMenuInicial=true;
                        break;
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