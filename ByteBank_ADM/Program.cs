using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Utilitarios;

Console.WriteLine("Boas Vindas! Você está no ByteBank Admnistração");

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

Funcionario funcionario = new Funcionario("12345698 - 12", 2000);
funcionario.Nome = "João";


Console.WriteLine("Bonificação: " + funcionario.getBonificacao());

Diretor diretor = new Diretor("53445421-33", 5000);
diretor.Nome = "Diretor";


Console.WriteLine("Bonificação: " + diretor.getBonificacao());

gerenciador.Registrar(funcionario);

gerenciador.Registrar(diretor);
{
    Console.WriteLine("Total de bonificação: " + gerenciador.getBonificacao());
}


Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);

funcionario.AumentarSalario();
Console.WriteLine("Novo salário: " + funcionario.Salario);
diretor.AumentarSalario();
Console.WriteLine("Novo salário: " + diretor.Salario);





