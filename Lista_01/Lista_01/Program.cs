namespace Lista_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroA, numeroB, numeroC;
            // -- Exercício 01 --

            //ler dados
            Console.WriteLine("Digite um valor inteiro para A: ");
            numeroA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um valor inteiro para B: ");
            numeroB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite um valor inteiro para C: ");
            numeroC = Convert.ToInt32(Console.ReadLine());


            //condicional
            if (numeroA + numeroB > numeroC)
                Console.WriteLine("A soma de A+B é maior do que C.");

            else if (numeroA + numeroB < numeroC)
                Console.WriteLine("A soma de A+B é menor do que C.");

            else
                Console.WriteLine("A soma de A+B é igual a C.");




            // -- Exercício 02 --

            int numero;
            string parOuImpar, positivoOuNegativo;

            //ler 
            Console.WriteLine("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());


            //condicional
            parOuImpar = numero % 2 == 0 ? "par" : "ímpar";
            positivoOuNegativo = numero >= 0 ? "positivo" : "negativo";


            //mensagem
            Console.WriteLine($"O número {numero} é {parOuImpar} e {positivoOuNegativo}! ");



            // -- Exercício 03 --


            string? nome, ehDoador, podeDoar;
            int idade;



            Console.WriteLine("Olá! Qual é o seu nome ? ");
            nome = Console.ReadLine();

            Console.WriteLine("Qual a sua idade ? ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Já doou sangue alguma vez ? Digite 's' para sim ou 'n' para não. ");
            ehDoador = Console.ReadLine();


            if (ehDoador == "n" && idade >= 60 && idade <= 69)

                podeDoar = "não pode";


            else
                podeDoar = idade >= 18 && idade <= 69 ? "pode" : "não pode";


            Console.WriteLine($"{nome} {podeDoar} doar sangue! ");






            // -- Exercício 04 --

            Console.WriteLine("\n\n---- Vamos descobrir o seu espírito animal... ----");
            Console.WriteLine("\n\n Tome cuidado com a digitação, digite igual como aparece na pergunta sem acentos: ");
            string? vertebradoOuNao, classeAnimal, dieta, resultado;

            Console.WriteLine("É vertebrado? [s/n] ");
            vertebradoOuNao = Console.ReadLine();

            if (vertebradoOuNao == "s")
            {
                Console.WriteLine("É ave ou mamifero? ");
                classeAnimal = Console.ReadLine();

                if (classeAnimal == "ave")
                {
                    Console.WriteLine("É carnivoro ou onivoro? ");
                    dieta = Console.ReadLine();
                    resultado = dieta == "carnivoro" ? "Águia" : "Pomba";
                    Console.WriteLine($"\nO animal é a {resultado}.");

                }
                else
                {
                    Console.WriteLine("É onivoro ou herbivoro? ");
                    dieta = Console.ReadLine();
                    resultado = dieta == "onivoro" ? "Homem" : "Vaca";
                    Console.WriteLine($"\nO animal é {resultado}.");
                }

            }
            else
            {
                Console.WriteLine("É inseto ou anelideo? ");
                classeAnimal = Console.ReadLine();

                if (classeAnimal == "inseto")
                {
                    Console.WriteLine("É hematofago ou herbivoro? ");
                    dieta = Console.ReadLine();
                    resultado = dieta == "hematofago" ? "Pulga" : "Lagarta";
                    Console.WriteLine($"\nO animal é a {resultado}.");

                }
                else
                {
                    Console.WriteLine("É hematofago ou onivoro? ");
                    dieta = Console.ReadLine();
                    resultado = dieta == "hematofago" ? "Sanguessuga" : "Minhoca";
                    Console.WriteLine($"\nO animal é {resultado}.");
                }
            }
        }
    }
}