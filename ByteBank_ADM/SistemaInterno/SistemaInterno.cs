namespace ByteBank_ADM.SistemaInterno
{
    internal class SistemaInterno
    {
        public static bool Logar(IAutenticavel funcionario, string login, string senha)
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
