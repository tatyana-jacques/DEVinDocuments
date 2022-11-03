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
        
            Listas.ListaLicencasFuncionamento.Add(licenca);
            Console.WriteLine("Documento cadastrado com sucesso!");
            Console.WriteLine(licenca);

        }

        public override void ListarDocumento()
        {
             foreach (LicencaFuncionamento x in Listas.ListaLicencasFuncionamento)
            {
                Console.WriteLine(x);
            }
        }

        public override void AlterarDocumento()
        {
            
        }

         public override string ToString()
        {
            return @$"Dados da Licença de Funcionamento:
            Código do documento : {codigoDocumento};
            Data de cadastro : {dataCadastro};
            Status do documento: {StatusDocumento};
            Nome do Estabelecimento: {NomeEstabelecimento};
            CNPJ: {CNPJ};
            Identificação do Funcionário: {IdentificacaoFuncionario};
            Endereço: {Endereco};
            Área de Atuação: {AreaAtuacao}
            =========================================================";

}


    }

}

   