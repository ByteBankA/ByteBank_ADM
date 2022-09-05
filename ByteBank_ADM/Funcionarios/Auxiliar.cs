namespace ByteBank_ADM.Funcionarios
{
    public class Auxiliar : Funcionario
    {

        public Auxiliar(string cpf) : base(cpf, 2000)
        {
            Console.WriteLine("Criando auxiliar");
        }

        public override double getBonificacao()
        {
            return Salario * 0.20;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.10;
        }
    }
}
