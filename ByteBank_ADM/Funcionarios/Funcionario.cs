namespace ByteBank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string? Nome { get; set; }
        public string? Cpf { get; private set; }
        public double Salario { get; protected set; }
        public abstract double getBonificacao();
        public abstract void AumentarSalario();

        public string Senha { get; set; }

        public Funcionario(string cpf, double salario)
        {
            Cpf = cpf;
            Salario = salario;
            Console.WriteLine("Criando funcionário");
            TotalDeFuncionarios++;
        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
