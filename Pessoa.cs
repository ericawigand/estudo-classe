public abstract class Pessoa
{
    public Pessoa(string nome, DateTime dataNascimento)
    {
        Nome = nome;
        DataNascimento = dataNascimento;
        Pessoa.TotalPessoas++;
    }
    public static int TotalPessoas { get; private set; }
    public string Nome { get; set; }
    public DateTime DataNascimento { get; }
    public string? Telefone { get; set; }

    public int CalcularIdade()
    {
        var diferencaDatas = DateTime.Now - DataNascimento;
        var anos = diferencaDatas.TotalDays / 365;
        var idade = (int) Math.Floor(anos);
        return idade;
    }

}