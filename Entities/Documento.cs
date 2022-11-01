
namespace DevInDocuments.Entities
{
    public class Documento
    {
        private int codigoDocumento;
        private DateTime dataCadastro;
        private DateTime dataAlteracao;
        private string nomeEstabelecimento;

        private string CNPJ;

        private Dictionary <int,string> statusDocumento = new Dictionary <int, string>{
            {1,"Ativo"},
            {2,"Em transição"},
            {3, "Suspenso"},


        };
    }
}