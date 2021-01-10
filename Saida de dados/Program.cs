using System;
using System.Globalization;

namespace Saida_de_dados
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritorio";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.00;
            double media = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine("{0}, Cujo o preço é $ {1:f2} ", produto1, preco1);
            Console.WriteLine($"{produto2}, Cujo o preço é $ {preco2:f2}");
            Console.WriteLine();
            Console.WriteLine("Registro " + idade + " anos de idade, codigo " + codigo +" e genero , "+ genero);
            Console.WriteLine();
            Console.WriteLine("Media com oito casas decimais: " + media);
            Console.WriteLine("Arredondado (Tres casas decimais): {0:f3}",media );
            Console.WriteLine("Separador decimal invariant culture: " + media.ToString("F3",CultureInfo.InvariantCulture));
        }

    }

}
