public class FuncionarioEspecial : Funcionario
{
    public FuncionarioEspecial(string nome, DateTime dataNascimento, string departamento, double salario, double bonusAnual) : base(nome, dataNascimento, departamento, salario)
    {
        BonusAnual = bonusAnual;
    }

    public double BonusAnual { get; }

    public new void DarAumento(double percentual)
    {
        Salario += Salario * (percentual / 100);
    }
}