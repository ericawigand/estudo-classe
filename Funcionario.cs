public class Funcionario : Pessoa
{
    public Funcionario(string nome, DateTime dataNascimento, string departamento, double salario) : base(nome, dataNascimento)
    {
        Departamento = departamento;
        Salario = salario;
    }
    public string Departamento { get; set; }    
    public double Salario { get; protected set; }
    
    public void DarAumento(double percentual)
    {
        if(percentual <= 10)
        {
            Salario += Salario * (percentual / 100);
        }
    }

}