
namespace DevInDocuments.Entities
{

    public class Listas
    {

        public static List<NotaFiscal> ListaNotasFiscais = new List<NotaFiscal> {
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
                valorTotalImposto: 7.50m)

         };
        public static List<LicencaFuncionamento> ListaLicencasFuncionamento = new List<LicencaFuncionamento> {
            
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
                statusDocumento: "Em tramitação")

         };
        public static List<Contrato> ListaContratos = new List<Contrato> {
            
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

    public static List<Funcionario> ListaFuncionarios()
    {
        Funcionario funcionarioA = new Funcionario(
            id: "2345",
            nome: "Paulo Sérgio",
            endereco: "Rua das Abe lhas n°201",
            dataNascimento: new DateTime(1990, 02, 15),
            nomePai: "Roberto Carlos",
            nomeMae: "Marta Magda",
            dataAdmissao: new DateTime(2020, 11, 08));

            Funcionario funcionarioB = new Funcionario(
                id: "1234",
                nome: "Rita de Cássio",
                endereco: "Rua das Borboletas n°201",
                dataNascimento: new DateTime(1990, 02, 15),
                nomePai: null,
                nomeMae: "Fernanda de Cássio",
                dataAdmissao: new DateTime(2020, 11, 08));

            var listaFuncionarios = new List<Funcionario> { funcionarioA, funcionarioB };

            return listaFuncionarios;
        }


    public static void ListarTodosDocumentos()
        {
            foreach (NotaFiscal x in ListaNotasFiscais)
            {
                Console.WriteLine(x);
            }
            foreach (LicencaFuncionamento x in ListaLicencasFuncionamento)
            {
                Console.WriteLine(x);
            }
            foreach (Contrato x in ListaContratos)
            {
                Console.WriteLine(x);
            }

        }




          //     public static List<Funcionario> ListaFuncionarios = new List<Funcionario>{

    //         new Funcionario(
    //             id: "35475627",
    //             nome: "Paulo Sérgio",
    //             endereco: "Rua das Abe lhas n°201",
    //             dataNascimento: new DateTime(1990, 02, 15),
    //             nomePai: "Roberto Carlos",
    //             nomeMae: "Marta Magda",
    //             dataAdmissao: new DateTime(2020, 11, 08)),
                
    //         new Funcionario(
    //             id: "12345678",
    //             nome: "Rita de Cássio",
    //             endereco: "Rua das Borboletas n°201",
    //             dataNascimento: new DateTime(1990, 02, 15),
    //             nomePai: null,
    //             nomeMae: "Fernanda de Cássio",
    //             dataAdmissao: new DateTime(2020, 11, 08))

    // };









    }
}