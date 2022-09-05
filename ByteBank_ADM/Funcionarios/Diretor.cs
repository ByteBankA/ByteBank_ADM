namespace ByteBank_ADM.Funcionarios
{
    public class Diretor : Funcionario
    {
        public override double getBonificacao()
        {

            return Salario + base.getBonificacao();
        }

        public Diretor(string cpf) : base(cpf)
        {
            Console.WriteLine("Criando diretor");
        }

    }
}
