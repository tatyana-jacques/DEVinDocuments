using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevInDocuments.Entities
{

    public class Listas
    {

        public static List<NotaFiscal> ListaNotasFiscais = new List<NotaFiscal> {
            new NotaFiscal(
                nomeEstabelecimento: "DEVinHouse",
                cnpj: "2934569783",
                identificacaoFuncionario: "12345678",
                nomeProduto: "Curso Frontend",
                tipoImposto: "ICMS",
                statusDocumento: "Ativo",
                valorTotal: 450.50m,
                valorTotalImposto: 45.05m),

            new NotaFiscal(
                nomeEstabelecimento: "Ruido Rosa",
                cnpj: "1248394039",
                identificacaoFuncionario: "35475627",
                nomeProduto: "Pacote de efeitos sonoros",
                tipoImposto: "IOF",
                statusDocumento: "Em tramitação",
                valorTotal: 230.00m,
                valorTotalImposto: 7.50m)

         };




        // public static List<NotaFiscal> ListaNotasFiscais()
        // {
        //     

        //    


        //     var listaNotasFiscas = new List<NotaFiscal> { };
        //     return listaNotasFiscas;
        // } // public static List<NotaFiscal> ListaNotasFiscais()
        // {
        //     NotaFiscal notaFiscalA = new NotaFiscal(
        //         nomeEstabelecimento: "DEVinHouse",
        //         cnpj: "2934569783",
        //         identificacaoFuncionario: "12345678",
        //         nomeProduto: "Curso Frontend",
        //         tipoImposto: "ICMS",
        //         status: "Ativo",
        //         valorTotal: 450.50m,
        //         valorTotalImposto: 45.05m);

        //     NotaFiscal notaFiscalB = new NotaFiscal(
        //         nomeEstabelecimento: "Ruido Rosa",
        //         cnpj: "1248394039",
        //         identificacaoFuncionario: "35475627",
        //         nomeProduto: "Pacote de efeitos sonoros",
        //         tipoImposto: "IOF",
        //         status: "Em tramitação",
        //         valorTotal: 230.00m,
        //         valorTotalImposto: 7.50m);


        //     var listaNotasFiscas = new List<NotaFiscal> { };
        //     return listaNotasFiscas;
        // }
        // {
        //     NotaFiscal notaFiscalA = new NotaFiscal(
        //         nomeEstabelecimento: "DEVinHouse",
        //         cnpj: "2934569783",
        //         identificacaoFuncionario: "12345678",
        //         nomeProduto: "Curso Frontend",
        //         tipoImposto: "ICMS",
        //         status: "Ativo",
        //         valorTotal: 450.50m,
        //         valorTotalImposto: 45.05m);

        //     NotaFiscal notaFiscalB = new NotaFiscal(
        //         nomeEstabelecimento: "Ruido Rosa",
        //         cnpj: "1248394039",
        //         identificacaoFuncionario: "35475627",
        //         nomeProduto: "Pacote de efeitos sonoros",
        //         tipoImposto: "IOF",
        //         status: "Em tramitação",
        //         valorTotal: 230.00m,
        //         valorTotalImposto: 7.50m);


        //     var listaNotasFiscas = new List<NotaFiscal> { };
        //     return listaNotasFiscas;
        // }



        public static List<Funcionario> ListaFuncionarios()
        {
            Funcionario funcionarioA = new Funcionario(
                id: "35475627",
                nome: "Paulo Sérgio",
                endereco: "Rua das Abe lhas n°201",
                dataNascimento: new DateTime(1990, 02, 15),
                nomePai: "Roberto Carlos",
                nomeMae: "Marta Magda",
                dataAdmissao: new DateTime(2020, 11, 08));

            Funcionario funcionarioB = new Funcionario(
                id: "12345678",
                nome: "Rita de Cássio",
                endereco: "Rua das Borboletas n°201",
                dataNascimento: new DateTime(1990, 02, 15),
                nomePai: null,
                nomeMae: "Fernanda de Cássio",
                dataAdmissao: new DateTime(2020, 11, 08));

            var listaFuncionarios = new List<Funcionario> { funcionarioA, funcionarioB };

            return listaFuncionarios;
        }

        // public static List<NotaFiscal> ListaNotasFiscais()
        // {
        //     NotaFiscal notaFiscalA = new NotaFiscal(
        //         nomeEstabelecimento: "DEVinHouse",
        //         cnpj: "2934569783",
        //         identificacaoFuncionario: "12345678",
        //         nomeProduto: "Curso Frontend",
        //         tipoImposto: "ICMS",
        //         status: "Ativo",
        //         valorTotal: 450.50m,
        //         valorTotalImposto: 45.05m);

        //     NotaFiscal notaFiscalB = new NotaFiscal(
        //         nomeEstabelecimento: "Ruido Rosa",
        //         cnpj: "1248394039",
        //         identificacaoFuncionario: "35475627",
        //         nomeProduto: "Pacote de efeitos sonoros",
        //         tipoImposto: "IOF",
        //         status: "Em tramitação",
        //         valorTotal: 230.00m,
        //         valorTotalImposto: 7.50m);


        //     var listaNotasFiscas = new List<NotaFiscal> { };
        //     return listaNotasFiscas;
        // }


        public static void ListarDocumentos(List <DevInDocuments> lista)
        {
            foreach (DevInDocuments x in lista)
            {
                Console.WriteLine(x);
            }

        }









    }
}