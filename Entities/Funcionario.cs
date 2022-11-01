using DevInDocuments.Entities.Exceptions;

namespace DevInDocuments.Entities
{
    public class Funcionario
    {
        public int Id {get;set;}
        public string Nome {get;set;}
        public string Endereco{get;set;}
        public DateTime DataNascimento {get;set;}
        public string[] Filiacao {get;set;} 
        public DateTime DataAdmissao {get;set;}

        public Funcionario (
            int id, 
            string nome, 
            string endereco,
            DateTime dataNascimento,
            string[]filiacao,
            DateTime dataAdmissao){
                if (nome == null)
            {
                throw new CampoNuloException("Insira um nome válido.");
            }
            if (endereco == null)
            {
                throw new CampoNuloException("Insira um endereço válido.");
            }
            if (filiacao == null)
            {
                throw new CampoNuloException("Insira um endereço válido.");
            }

            Id = id;
            Nome = nome;
            Endereco = endereco;
            DataNascimento = dataNascimento;
            Filiacao =filiacao;
            DataAdmissao = dataAdmissao;
           
        }

    }
}