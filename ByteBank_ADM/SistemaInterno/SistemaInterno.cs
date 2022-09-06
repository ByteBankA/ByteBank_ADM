using ByteBank_ADM.ParceriaComercial;

namespace ByteBank_ADM.SistemaInterno
{
    internal class SistemaInterno
    {
        public static bool Logar(Autenticavel funcionario, string login, string senha)
        {
            bool usuaarioAutenticado = funcionario.Autenticar(login, senha);
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

        public static bool Logar(ParceiroComercial funcionario, string login, string senha)
        {
            bool usuaarioAutenticado = funcionario.Autenticar(login, senha);
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
