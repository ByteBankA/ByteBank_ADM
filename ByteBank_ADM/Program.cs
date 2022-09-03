using ByteBank_ADM.Funcionarios;

Console.WriteLine("Boas Vindas! Você está no ByteBank Admnistração");

Funcionario funcionario = new Funcionario();
funcionario.Nome = "João";
funcionario.Cpf = "12345698-12";
funcionario.Salario = 2000;

Console.WriteLine("Bonificação: " + funcionario.getBonificacao());