using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.ParceriaComercial;
using ByteBank_ADM.SistemaInterno;

Console.WriteLine("Boas Vindas! Você está no ByteBank Admnistração");

//CalcularBonificao();
UsarSistema();

void CalcularBonificao()
{


    //GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    //Designer designer = new Designer("123.456.789-01");
    //designer.Nome = "Designer";

    //Diretor diretor = new Diretor("234.567.891-01");
    //diretor.Nome = "Diretor";

    //Auxiliar auxiliar = new Auxiliar("345.678.912-01");
    //auxiliar.Nome = "Auxiliar";

    //GerenteDeContas gerenteDeContas = new GerenteDeContas("456.789.123 - 01");
    //gerenteDeContas.Nome = "Gerente de Contas";

    //Desenvolvedor desenvolvedor = new Desenvolvedor("567-890-123-01");
    //desenvolvedor.Nome = "Desenvolvedor";

    //gerenciador.Registrar(designer);
    //gerenciador.Registrar(diretor);
    //gerenciador.Registrar(auxiliar);
    //gerenciador.Registrar(gerenteDeContas);
    //gerenciador.Registrar(desenvolvedor);

    //Console.WriteLine("Total de bonificação: " + gerenciador.getBonificacao());


}

void UsarSistema()
{
    SistemaInterno sistemaInterno = new SistemaInterno();

    Diretor diretor = new Diretor("234.567.891-01");
    diretor.Nome = "Diretor";
    diretor.Senha = "123";
    diretor.Login = "D";


    GerenteDeContas gerenteDeContas = new GerenteDeContas("456.789.123 - 01");
    gerenteDeContas.Nome = "Gerente de Contas";
    gerenteDeContas.Senha = "456";
    gerenteDeContas.Login = "G";

    Funcionario designer = new Designer("123.456.789-01");
    designer.Nome = "Designer";
    designer.Senha = "123";

    ParceiroComercial parceiroComercial = new ParceiroComercial();
    parceiroComercial.Login = "P";
    parceiroComercial.Senha = "123";

    SistemaInterno.Logar(diretor, "D", "123");
    SistemaInterno.Logar(gerenteDeContas, "G", "456");
    SistemaInterno.Logar(parceiroComercial, "P", "123");

}




