using DevInDocuments.Entities.Exceptions;

namespace DevInDocuments.Entities
{
    public class Funcionario
    {
        public string Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public DateTime DataNascimento { get; set; }
        public List<string> Filiacao { get; set; }
        public DateTime DataAdmissao { get; set; }

        public Funcionario(
            string id,
            string nome,
            string endereco,
            DateTime dataNascimento,
            string? nomePai,
            string? nomeMae,
            DateTime dataAdmissao)
        {
    
            Id = id;
            Nome = nome;
            Endereco = endereco;
            DataNascimento = dataNascimento;
            Filiacao = new List<string>();
            DataAdmissao = dataAdmissao;

            if (nomePai != null)
            {
                Filiacao.Add(nomePai);
            }
            if (nomeMae != null)
            {
                Filiacao.Add(nomeMae);
            }

        }

        public override string ToString()
        {
        return @$"Dados do funcionário operando:
            Identidade: {Id};
            Nome: {Nome};
            Endereço: {Endereco};
            Data de nascimento: {DataNascimento.ToString("dd/MM/yyyy")};
            Filiação: {string.Join(", ", Filiacao)};
            Data de admissão: {DataAdmissao.ToString("dd/MM/yyyy")}";

        }
    }

}

