namespace ByteBank_ADM.Funcionarios
{
    public class GerenteDeContas : Funcionario
    {
        public string Senha { get; set; }

        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {
            Console.WriteLine("Criando Diretor de Contas");
        }

        public override double getBonificacao()
        {

            return Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            Salario *= 0.5;
        }

        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}
