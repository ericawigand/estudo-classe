// See https://aka.ms/new-console-template for more information
var p1 = new Funcionario("Renato", new DateTime(1983, 10, 28), "TI", 12.00);
var p2 = new FuncionarioEspecial("Erica", new DateTime(1984, 10, 22), "TI", 13.00, 19);
var p3 = new Funcionario("Renato", new DateTime(1983, 10, 28), "TI", 12.00);


Console.WriteLine(Pessoa.TotalPessoas);
p2.DarAumento(12);

ImprimeDadosPessoa(p1);
ImprimeDadosPessoa(p2);


void ImprimeDadosPessoa(Pessoa pessoa)
{
    Console.WriteLine();
    Console.WriteLine("Nome: {0}", pessoa.Nome);
    Console.WriteLine("Idade: {0} anos", pessoa.CalcularIdade());
    if(pessoa is Funcionario)
    {
        var funcionario = (Funcionario) pessoa;
        Console.WriteLine("Salário: {0}", funcionario.Salario);
    }

    if(pessoa is FuncionarioEspecial)
    {
        var fe = (FuncionarioEspecial) pessoa;
        Console.WriteLine("Bônus Anual: {0}", fe.BonusAnual);
    }
}
