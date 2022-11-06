
using DevInDocuments.Entities.Enumerators;
namespace DevInDocuments.Entities
{

    public static class Listas
    {
        public static List<DevInDocuments> Lista = new List<DevInDocuments> {
            new NotaFiscal(
                nomeEstabelecimento: "DEVinHouse",
                cnpj: "2934569783",
                identificacaoFuncionario: "1234",
                dataAlteracao: new DateTime (2020,12,03),
                nomeProduto: "Curso Frontend",
                statusDocumento: Status.Ativo,
                tipoImposto: TipoImposto.ICMS,
                valorTotal: 450.50m,
                valorTotalImposto: 45.05m),

            new NotaFiscal(
                nomeEstabelecimento: "Ruido Rosa",
                cnpj: "1248394039",
                identificacaoFuncionario: "2345",
                dataAlteracao: new DateTime (2012,10,03),
                nomeProduto: "Pacote de efeitos sonoros",
                tipoImposto: TipoImposto.IOF,
                statusDocumento: Status.Tramitando,
                valorTotal: 230.00m,
                valorTotalImposto: 7.50m),

            new LicencaFuncionamento(
                nomeEstabelecimento: "DEVinHouse",
                cnpj: "2934569783",
                identificacaoFuncionario: "1234",
                dataAlteracao: new DateTime (2022,07,03),
                endereco: "Rua Anita Garibaldi n°20",
                areaAtuacao: AreaAtuacao.Tecnologia,
                statusDocumento: Status.Suspenso),

            new LicencaFuncionamento(
                nomeEstabelecimento: "Ruido Rosa",
                cnpj: "1248394039",
                identificacaoFuncionario: "2345",
                dataAlteracao: new DateTime (2021,11,11),
                endereco: "Praça XV de Novembro n°90",
                areaAtuacao: AreaAtuacao.Outro,
                statusDocumento: Status.Tramitando),

                new Contrato(
                nomeEstabelecimento: "DEVinHouse",
                cnpj: "2934569783",
                identificacaoFuncionario: "1234",
                dataAlteracao: new DateTime (2020,02,12),
                finalidade: "Prestação de serviços educacionais",
                testemunhas: new string[2] {"Maria Rita", "Marisa Monte"},
                dataExpiracao: new DateTime (2023,05,04),
                statusDocumento: Status.Suspenso),

            new Contrato(
                nomeEstabelecimento: "Ruido Rosa",
                cnpj: "1248394039",
                identificacaoFuncionario: "2345",
                dataAlteracao: new DateTime (2013,05,08),
                finalidade: "Prestação de serviços artísticos.",
                testemunhas: new string[2] {"Rita Lee", "Sergio Dias"},
                dataExpiracao: new DateTime (2030,07,08),
                statusDocumento: Status.Ativo)

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