using ByteBank_ADM.Funcionarios;

Console.WriteLine("Boas Vindas! Você está no ByteBank Admnistração");

Funcionario funcionario = new Funcionario();
funcionario.Nome = "João";
funcionario.Cpf = "12345698-12";
funcionario.Salario = 2000;

Console.WriteLine("Bonificação: " + funcionario.getBonificacao());

Diretor diretor = new Diretor();
diretor.Nome = "Diretor";
diretor.Cpf = "53445421-33";
diretor.Salario = 5000;

Console.WriteLine("Bonificação: " + diretor.getBonificacao());
