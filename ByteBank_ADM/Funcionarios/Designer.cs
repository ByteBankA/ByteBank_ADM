namespace ByteBank_ADM.Funcionarios
{
    internal class Designer : Funcionario
    {
        public Designer(string cpf) : base(cpf, 3000)
        {
            Console.WriteLine("Criando designer.");
        }
        public override double getBonificacao()
        {

            return Salario * 0.17;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.11;
        }

    }
}

