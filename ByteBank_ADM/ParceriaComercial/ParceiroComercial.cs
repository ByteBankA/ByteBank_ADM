namespace ByteBank_ADM.ParceriaComercial
{
    public class ParceiroComercial
    {
        public string Senha { get; set; }

        public string Login { get; set; }
        public bool Autenticar(string login, string senha)
        {
            return Senha == senha && Login == login;
        }
    }
}
