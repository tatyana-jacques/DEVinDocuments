using DevInDocuments.Entities;
using DevInDocuments.Entities.Exceptions;

//Instanciação dos funcionários
Funcionario funcionarioA = new Funcionario(
id: 354756273,
nome: "Paulo Sérgio",
endereco: "Rua das Abelhas n°201",
dataNascimento: new DateTime(1990, 02, 15),
nomePai: "Roberto Carlos",
nomeMae: "Marta Magda",
dataAdmissao: new DateTime(2020, 11, 08));

Funcionario funcionarioB = new Funcionario(
id: 123456789,
nome: "Rita de Cássio",
endereco: "Rua das Borboletas n°201",
dataNascimento: new DateTime(1990, 02, 15),
nomePai: null,
nomeMae: "Fernanda de Cássio",
dataAdmissao: new DateTime(2020, 11, 08));


//Lista de funcionários
var funcionarios = new List<Funcionario> { funcionarioA, funcionarioB };


//Dicionários para seleção de operações de menu
var menuInicial = new Dictionary<int, string>
 {
            {1, "Cadastrar documento"},
            {2, "Editar documento"},
            {3, "Listar documento"},
            {4, "Visualizar total de documentos."}
};

var menuEditar = new Dictionary<int, string>
 {
            {1, "Alterar itens do documento"},
            {2, "Alterar status do documento"},
};

var menuListar = new Dictionary<int, string>
 {
            {1, "Listar dados do documento"},
            {3, "Listar documentos ativos"},
            {4, "Listar documentos em tramitação"},
            {5, "Listar documentos suspensos"},
            {6, "Listar notas fiscais"},
            {7,"Listar licenças de funcionamento"},
            {8, "Listar contratos"},
            {9, "Listar todos os documentos"},
};


//Variáveis de conferência e inserção de dados
bool usuarioIdentificado = false;
int identidadeInserida;

//Interação com usuário
Console.WriteLine("Olá Funcionário(a).");
while (usuarioIdentificado == false)
{
    try
    {
        Console.Write("Insira o número de sua identidade para começar:");

        bool verificarIdentidade = int.TryParse(Console.ReadLine(), out identidadeInserida);
        var identidadeEncontrada = funcionarios.Where(p => p.Id == identidadeInserida).First();
        Console.WriteLine(@$"Bem vindo(a) ao sistema de cadastro e consulta de documentos.
    {identidadeEncontrada}");
        Console.WriteLine(identidadeEncontrada.GetType().ToString());
        usuarioIdentificado = true;
    }
    catch (InvalidOperationException)
    {

        Console.WriteLine("A identificação do usuário é obrigatória!");
    }
}

Console.WriteLine(@$"Insira o número da operação que deseja fazer:
1- Cadastrar documento;
2-Editar documento;
3-Listar documentos;
4-Visualizar total de documentos.");





