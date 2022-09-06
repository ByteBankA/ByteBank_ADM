using ByteBank_ADM.SistemaInterno;

namespace ByteBank_ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        protected FuncionarioAutenticavel(string cpf, double salario) : base(cpf, salario)
        {
        }

        public string Senha { get; set; }

        public string Login { get; set; }

        public bool Autenticar(string login, string senha)
        {
            return Senha == senha && Login == login;
        }
    }
}
