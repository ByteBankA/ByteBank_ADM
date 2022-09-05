﻿namespace ByteBank_ADM.Funcionarios
{
    public class Diretor : Funcionario
    {
        public string Senha { get; set; }
        public override double getBonificacao()
        {

            return Salario * 0.50;
        }

        public Diretor(string cpf) : base(cpf, 5000)
        {
            Console.WriteLine("Criando diretor");
        }
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

    }
}
