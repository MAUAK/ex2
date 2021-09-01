using System;
using System.Globalization;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarando variaveis da classe Pessoa
            Pessoa pessoa1, pessoa2;
            
            //comentario teste

            //Instanciando variaveis
            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            //Pedindo o nome
            Console.WriteLine("Digite o nome da primeira pessoa:");
            //Gravando o nome para as variaveis do objeto da classe Pessoa
            pessoa1.nome = Console.ReadLine();

            //Pedindo a idade
            Console.WriteLine("\nDigite a idade do " + pessoa1.nome + ":");
            //Gravando a idade para as variaveis do objeto da classe Pessoa
            pessoa1.idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Pedindo o nome da segunda pessoa
            Console.WriteLine("\nDigite o nome da segunda pessoa:");
            //Gravando o nome para as variaveis do objeto da classe Pessoa
            pessoa2.nome = Console.ReadLine();

            //Pedindo a idade
            Console.WriteLine("\nDigite a idade do " + pessoa2.nome + ":");
            //Gravando o nome para as variaveis do objeto da classe Pessoa
            pessoa2.idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Escrevendo a idade e o nome das pessoas informadas
            Console.WriteLine("\n\nA idade do "+ pessoa1.nome + " é igual a " + pessoa1.idade + ".");
            Console.WriteLine("\nA idade do "+ pessoa2.nome + " é igual a " + pessoa2.idade + ".");

            //Comparando idades da pessoa 1 com a pessoa 2
            if (pessoa1.idade > pessoa2.idade)
            {
                //Escrevendo q a pessoa 1 é mais velha
                Console.WriteLine("\n\nPessoa mais velha: " + pessoa1.nome);
            }
            //Comparando idades da pessoa 2 com a pessoa 1
            else if (pessoa2.idade > pessoa1.idade)
            {
                //Escrevendo q a pessoa 2 é mais velha
                Console.WriteLine("\n\nPessoa mais velha: " + pessoa2.nome);
            }
            //Caso não forem nenhuma das comparações acima
            else
            {
                //Escrevendo q as duas pessoas tem a mesma idade
                Console.WriteLine("\n\nO " + pessoa1.nome + " e o " + pessoa2.nome + " tem a mesma idade.");
            }
            Console.ReadKey();
        }
    }
}
