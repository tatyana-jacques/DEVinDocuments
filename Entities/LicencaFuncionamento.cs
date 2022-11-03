using DevInDocuments.Entities.Exceptions;

namespace DevInDocuments.Entities
{
    public class LicencaFuncionamento : DevInDocuments
    {
        public string Endereco { get; set; }
        public string AreaAtuacao {get;set;}

        public LicencaFuncionamento(
           string nomeEstabelecimento,
           string cnpj,
           string identificacaoFuncionario,
           string endereco,
           string areaAtuacao,
           string statusDocumento
           ): 
           base(nomeEstabelecimento, cnpj, identificacaoFuncionario, statusDocumento)
        {
            if (endereco == null)
            {
                throw new CampoNuloException("Insira um endereço válido.");
            }
            if (areaAtuacao == null)
            {
                throw new CampoNuloException("Insira uma área de atuação.");
            }

            Endereco = endereco;
            AreaAtuacao = areaAtuacao;
        }

       public void CadastrarDocumento(LicencaFuncionamento licenca)
        {
        
            // Listas.ListaLicenca.Add(licenca);
            // Console.WriteLine("Documento cadastrado com sucesso!");
            // Console.WriteLine(licenca);

        }

        public override void ListarDocumento()
        {
        }

        public override void AlterarItensDocumento(
            string nomeEstabelecimento,
            string cnpj,
            string identificacaoFuncionario)
        {
            if (nomeEstabelecimento == null)
            {
                throw new CampoNuloException("Insira um nome de estabelecimento válido.");
            }
            if (cnpj == null)
            {
                throw new CampoNuloException("Insira um nome de estabelecimento válido.");
            }
            NomeEstabelecimento = nomeEstabelecimento;
            CNPJ = cnpj;
            DataAlteracao = DateTime.Now;
            IdentificacaoFuncionario = identificacaoFuncionario;
        }

    }
}