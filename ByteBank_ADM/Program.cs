using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Utilitarios;

Console.WriteLine("Boas Vindas! Você está no ByteBank Admnistração");

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

Funcionario funcionario = new Funcionario("12345698 - 12");
funcionario.Nome = "João";
funcionario.Salario = 2000;

Console.WriteLine("Bonificação: " + funcionario.getBonificacao());

Diretor diretor = new Diretor("53445421-33");
diretor.Nome = "Diretor";
diretor.Salario = 5000;

Console.WriteLine("Bonificação: " + diretor.getBonificacao());

gerenciador.Registrar(funcionario);

gerenciador.Registrar(diretor);
{
    Console.WriteLine("Total de bonificação: " + gerenciador.getBonificacao());
}


Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);





