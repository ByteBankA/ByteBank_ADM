namespace ByteBank_ADM.Funcionarios
{
    public class Diretor : Funcionario
    {
        public override double getBonificacao()
        {
            return Salario;
        }
    }
}
