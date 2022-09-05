namespace ByteBank_ADM.Funcionarios
{
    public class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string? Nome { get; set; }
        public string? Cpf { get; private set; }
        public double Salario { get; set; }
        public virtual double getBonificacao()
        {
            return Salario * 0.1;
        }

        public Funcionario(string cpf)
        {
            Cpf = cpf;
            Console.WriteLine("Criando funcionário");
            TotalDeFuncionarios++;
        }
        public void AumentarSalario()
        {
            Salario *= 1.1;
        }
    }
}
