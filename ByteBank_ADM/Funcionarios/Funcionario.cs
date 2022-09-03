namespace ByteBank_ADM.Funcionarios
{
    public class Funcionario
    {
        private string Nome { get; set; }
        private string Cpf { get; set; }
        private double Salario { get; set; }

        public double getBonificacao()
        {
            return Salario * 0.1;
        }
    }
}
