using DevInDocuments.Entities.Enums;
using DevInDocuments.Entities.Exceptions;
namespace DevInDocuments.Entities
{
    public class NotaFiscal : Documento
    {
        public decimal ValorTotal { get; set; }
        public string NomeProduto { get; set; }

        public TipoImposto Imposto { get; set; }

        public NotaFiscal(
            int codigoDocumento,
            string nomeEstabelecimento,
            string cnpj,
            StatusDocumento status,
            int identificacaoFuncionario,
            decimal valorTotal,
            string nomeProduto,
            TipoImposto imposto) :
        base(codigoDocumento,
             nomeEstabelecimento,
             cnpj,
             status,
             identificacaoFuncionario)
        {
            if (nomeProduto == null)
            {
                throw new CampoNuloException("Insira um nome de produto válido.");
            }
            ValorTotal = valorTotal;
            NomeProduto = nomeProduto;
            Imposto = imposto;
        }

    }
}