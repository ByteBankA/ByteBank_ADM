using ByteBank_ADM.Funcionarios;

namespace ByteBank_ADM.SistemaInterno
{
    internal class SistemaInterno
    {
        public static bool Logar(Diretor funcionario, string senha)
        {
            bool usuaarioAutenticado = funcionario.Autenticar(senha);
            if (usuaarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao sistema.");
                return true;
            }
            else
            {
                Console.WriteLine("Erro!");
                return false;
            }
        }

        public static bool Logar(GerenteDeContas funcionario, string senha)
        {
            bool usuaarioAutenticado = funcionario.Autenticar(senha);
            if (usuaarioAutenticado)
            {
                Console.WriteLine("Bem vindo ao sistema.");
                return true;
            }
            else
            {
                Console.WriteLine("Erro!");
                return false;
            }
        }
    }
}
