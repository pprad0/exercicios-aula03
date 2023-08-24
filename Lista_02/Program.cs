namespace Lista_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--- Exercício 05 ---

            int codigo, quantidade;
            string produto = "";
            float preco = 0, valorTotal;

            Console.WriteLine("\nQual o código? Digite um número de 1 a 6: ");
            codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nE a quantidade? ");
            quantidade = Convert.ToInt32(Console.ReadLine());

            switch (codigo)
            {

                case 1:
                    produto = "Cachorro quente";
                    preco = 10.00F;
                    break;

                case 2:
                    produto = "X — Salada";
                    preco = 15.00F;
                    break;

                case 3:
                    produto = "X — Bacon";
                    preco = 18.00F;

                    break;

                case 4:
                    produto = "Bauru";
                    preco = 12.00F;
                    break;

                case 5:
                    produto = "Refrigerante";
                    preco = 8.00F;
                    break;

                case 6:
                    produto = "Suco de laranja";
                    preco = 13.00F;
                    break;
            }

            valorTotal = quantidade * preco;
            Console.WriteLine($"\nProduto: {produto} \nValor a pagar: R${Math.Round(valorTotal, 2)}");
            Console.WriteLine($"\nDébito ou crédito ? ");
            Console.ReadLine();



            //--- Exercício 06 ---

            int codigoDoCargo;
            float percentualAjuste = 0, salario;
            string cargo = "";
            string? nome;


            Console.WriteLine("\nOlá! Qual o seu nome? ");
            nome = Console.ReadLine();

            Console.WriteLine("\nQual o código do cargo? Digite um número de 1 a 6: ");
            codigoDoCargo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nO salário? ");
            salario = Convert.ToSingle(Console.ReadLine());


            switch (codigoDoCargo)
            {
                case 1:
                    cargo = "Gerente";
                    percentualAjuste = 0.10F;
                    break;

                case 2:
                    cargo = "Vendedor";
                    percentualAjuste = 0.7F;
                    break;

                case 3:
                    cargo = "Supervisor";
                    percentualAjuste = 0.9F;

                    break;

                case 4:
                    cargo = "Motorista";
                    percentualAjuste = 0.6F;
                    break;

                case 5:
                    cargo = "Estoquista";
                    percentualAjuste = 0.5F;
                    break;

                case 6:
                    cargo = "Técnico de Ti";
                    percentualAjuste = 0.8F;
                    break;
            }

            Console.WriteLine($"\nNome do colaborador: {nome}. \nCargo: {cargo} \nSalário reajustado para: R${salario + (salario * percentualAjuste)} .");
            Console.WriteLine("\nParabéns pelo aumento!");


            // --- Exercício 7 ---

            int numero1, numero2, codigoOperacao, resultado = 0;
            bool validez = true;


            Console.WriteLine("\nDigite o numero1: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite o numero2: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite código da operação: \n1-Soma \n2-Subtração \n3-Divisão \n4-Multiplicação");
            codigoOperacao = Convert.ToInt32(Console.ReadLine());


            switch (codigoOperacao)
            {
                case 1:
                    resultado = numero1 + numero2;
                    break;

                case 2:
                    resultado = numero1 - numero2;
                    break;

                case 3:
                    resultado = numero1 * numero2;
                    break;

                case 4:
                    resultado = numero1 / numero2;
                    break;

                default:
                    validez = false;
                    break;
            }

            if (!validez)
                Console.WriteLine("\nOperação inválida!");

            else
                Console.WriteLine($"\nO resultado da operação é: {resultado} ");



            // --- Exercício 8 ---

            int operacao = 0;
            float saldo = 1000, saque = 0, deposito = 0;


            Console.WriteLine("\nQual operação você deseja fazer? \n1-Saldo \n2-Saque \n3-Depósito");
            operacao = Convert.ToInt32(Console.ReadLine());

            switch (operacao)
            {
                case 1:
                    Console.WriteLine($"\nSeu saldo é {saldo}");
                    break;

                case 2:
                    Console.WriteLine("\nQual o valor do saque? ");
                    saque = Convert.ToSingle(Console.ReadLine());

                    if (saque < saldo)
                    {
                        saldo -= saque;
                        Console.WriteLine($"\nSeu saldo atual é R${saldo}");
                    }
                    else
                    {
                        Console.WriteLine($"\nSaldo insuficiente!");
                    }
                    break;

                case 3:
                    Console.WriteLine($"\nDigite o valor do depósito: ");
                    deposito = Convert.ToSingle(Console.ReadLine());
                    saldo += deposito;
                    Console.WriteLine($"\nSeu saldo atual é R${saldo}");
                    break;

                default:
                    Console.WriteLine("\nOperação inválida!");
                    break;

            }
        }
    }
}