using ByteBank_ADM.Funcionarios;

namespace ByteBank_ADM.SistemaInterno
{
    public abstract class Autenticavel : Funcionario
    {
        public string Senha { get; set; }
        public Autenticavel(string cpf, double salario) : base(cpf, salario)
        {

        }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

        // Tornar a classe abstrata para não precisar implementar métodos desnecessários
        //public override void AumentarSalario()
        //{
        //    Console.WriteLine("");
        //}

        //public override double getBonificacao()
        //{
        //    return 0;
        //}
    }
}
