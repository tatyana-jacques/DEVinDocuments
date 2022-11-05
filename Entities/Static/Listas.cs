
namespace DevInDocuments.Entities
{

    public static class Listas
    {
        public static List<DevInDocuments> Lista = new List<DevInDocuments> {
            new NotaFiscal(
                nomeEstabelecimento: "DEVinHouse",
                cnpj: "2934569783",
                identificacaoFuncionario: "1234",
                nomeProduto: "Curso Frontend",
                tipoImposto: "ICMS",
                statusDocumento: "Ativo",
                valorTotal: 450.50m,
                valorTotalImposto: 45.05m),

            new NotaFiscal(
                nomeEstabelecimento: "Ruido Rosa",
                cnpj: "1248394039",
                identificacaoFuncionario: "2345",
                nomeProduto: "Pacote de efeitos sonoros",
                tipoImposto: "IOF",
                statusDocumento: "Em tramitação",
                valorTotal: 230.00m,
                valorTotalImposto: 7.50m),

            new LicencaFuncionamento(
                nomeEstabelecimento: "DEVinHouse",
                cnpj: "2934569783",
                identificacaoFuncionario: "1234",
                endereco: "Rua Anita Garibaldi n°20",
                areaAtuacao: "Tecnologia",
                statusDocumento: "Ativo"),

            new LicencaFuncionamento(
                nomeEstabelecimento: "Ruido Rosa",
                cnpj: "1248394039",
                identificacaoFuncionario: "2345",
                endereco: "Praça XV de Novembro n°90",
                areaAtuacao: "Outro",
                statusDocumento: "Em tramitação"),

                new Contrato(
                nomeEstabelecimento: "DEVinHouse",
                cnpj: "2934569783",
                identificacaoFuncionario: "1234",
                finalidade: "Prestação de serviços educacionais",
                testemunhas: new string[2] {"Maria Rita", "Marisa Monte"},
                dataExpiracao: new DateTime (2023,05,04),
                statusDocumento: "Ativo"),

            new Contrato(
                nomeEstabelecimento: "Ruido Rosa",
                cnpj: "1248394039",
                identificacaoFuncionario: "2345",
                finalidade: "Prestação de serviços artísticos.",
                testemunhas: new string[2] {"Rita Lee", "Sergio Dias"},
                dataExpiracao: new DateTime (2030,07,08),
                statusDocumento: "Em tramitação")

        };


        public static List<Funcionario> Funcionarios = new List<Funcionario>{
        new Funcionario(
            id: "2345",
            nome: "Paulo Sérgio",
            endereco: "Rua das Abe lhas n°201",
            dataNascimento: new DateTime(1990, 02, 15),
            nomePai: "Roberto Carlos",
            nomeMae: "Marta Magda",
            dataAdmissao: new DateTime(2020, 11, 08)),

        new Funcionario(
            id: "1234",
            nome: "Rita de Cássio",
            endereco: "Rua das Borboletas n°201",
            dataNascimento: new DateTime(1990, 02, 15),
            nomePai: null,
            nomeMae: "Fernanda de Cássio",
            dataAdmissao: new DateTime(2020, 11, 08))
        };


    public static void ListarTodosDocumentos()
        {
            foreach (DevInDocuments x in Lista)
            {
                Console.WriteLine(x);
            }

        }


    }
}