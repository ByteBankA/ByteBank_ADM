namespace ByteBank_ADM.Funcionarios
{
    public class Diretor : Funcionario
    {
        public override double getBonificacao()
        {

            return Salario + base.getBonificacao();
        }

        public Diretor(string cpf, double salario) : base(cpf, salario)
        {
            Console.WriteLine("Criando diretor");
        }
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

    }
}
