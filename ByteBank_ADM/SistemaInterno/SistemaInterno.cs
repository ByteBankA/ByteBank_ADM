namespace ByteBank_ADM.SistemaInterno
{
    internal class SistemaInterno
    {
        public static bool Logar(Autenticavel funcionario, string senha)
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
