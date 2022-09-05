using ByteBank_ADM.Funcionarios;

namespace ByteBank_ADM.Utilitarios
{
    public class GerenciadorDeBonificacao
    {
        private double totalBonificacao { get; set; }

        public void Registrar(Funcionario funcionario)
        {
            totalBonificacao += funcionario.getBonificacao();
        }
        public double getBonificacao()
        {
            return totalBonificacao;
        }
    }

}
