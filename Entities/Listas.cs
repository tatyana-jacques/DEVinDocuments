using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevInDocuments.Entities
{
    public class Listas
    {
       
       public static List <Funcionario> ListaFuncionarios (){
        Funcionario funcionarioA = new Funcionario(
        id: 35475627,
        nome: "Paulo Sérgio",
        endereco: "Rua das Abe lhas n°201",
        dataNascimento: new DateTime(1990, 02, 15),
        nomePai: "Roberto Carlos",
        nomeMae: "Marta Magda",
        dataAdmissao: new DateTime(2020, 11, 08));

        Funcionario funcionarioB = new Funcionario(
        id: 12345678,
        nome: "Rita de Cássio",
        endereco: "Rua das Borboletas n°201",
        dataNascimento: new DateTime(1990, 02, 15),
        nomePai: null,
        nomeMae: "Fernanda de Cássio",
        dataAdmissao: new DateTime(2020, 11, 08));

        var listaFuncionarios = new List <Funcionario> {funcionarioA, funcionarioB};

        return listaFuncionarios;


       }
       
        
        
        

    
       


    }
}