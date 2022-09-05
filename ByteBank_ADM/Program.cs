using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Utilitarios;

Console.WriteLine("Boas Vindas! Você está no ByteBank Admnistração");

CalcularBonificao();

void CalcularBonificao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer designer = new Designer("123.456.789-01");
    designer.Nome = "Designer";

    Diretor diretor = new Diretor("234.567.891-01");
    diretor.Nome = "Diretor";

    Auxiliar auxiliar = new Auxiliar("345.678.912-01");
    auxiliar.Nome = "Auxiliar";

    GerenteDeContas gerenteDeContas = new GerenteDeContas("456.789.123 - 01");
    gerenteDeContas.Nome = "Gerente de Contas";

    Desenvolvedor desenvolvedor = new Desenvolvedor("567-890-123-01");
    desenvolvedor.Nome = "Desenvolvedor";

    gerenciador.Registrar(designer);
    gerenciador.Registrar(diretor);
    gerenciador.Registrar(auxiliar);
    gerenciador.Registrar(gerenteDeContas);
    gerenciador.Registrar(desenvolvedor);

    Console.WriteLine("Total de bonificação: " + gerenciador.getBonificacao());
}



